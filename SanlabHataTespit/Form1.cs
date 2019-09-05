using Be.Timvw.Framework.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanlabHataTespit
{
    public partial class Form1 : Form
    {
        ToolTip toolTip = new ToolTip();
        Hata DataGridViewSelectGlobalHata;
        SanlabHataTespitVTEntities contextDb = new SanlabHataTespitVTEntities();
        OpenFileDialog dosya;
        Hata searchHata;
        public List<PictureBox> Hatapictureboxes = new List<PictureBox>();
        public List<PictureBox> Cozumpictureboxes = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // toolTip.ToolTipIcon = ToolTipIcon.Info;

            // TODO: Bu kod satırı 'sanlabHataTespitVTDataSet.Hata' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            KisiDoldur(comboBoxGonderenKisiler);
            KisiDoldur(comboBoxMailGonder);
            KategoriDoldur();
            MusteriDoldur();

            //Otomatik doldurma için Gerekli olan Kişi verilerini yüklüyorum.
            //Silme işleminden sonra Güncelle;

            //Otomatik doldurma için Gerekli olan Hata verilerini yüklüyorum.
            var Hatasearch = contextDb.Hata;
            AutoCompleteStringCollection autoComplete2 = new AutoCompleteStringCollection();
            foreach (var item in Hatasearch)
            {
                autoComplete2.Add(item.hataAd);
            }
            textBoxSearch.AutoCompleteCustomSource = autoComplete2;
            textBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            byte[] resimByte = null;
            Hata hata = new Hata();
            hata.hataAd = textBoxHataTanim.Text;
            hata.hataAciklama = textBoxAciklama.Text;
            hata.kategoriID = (int)comboBoxKategori.SelectedValue;
            hata.hataCozum = null;
            hata.hataTarih = DateTime.Now;
            hata.kisiID = (int)comboBoxGonderenKisiler.SelectedValue;
            hata.cozumVarmi = false;
            hata.musteriID = (int)comboBoxMusteri.SelectedValue;
            contextDb.Hata.Add(hata);
            contextDb.SaveChanges();
            
            if (Hatapictureboxes != null)
            {
                foreach (var item in Hatapictureboxes)
                {
                    //  pictureBoxHata.ImageLocation = item;
                    Image img = item.Image;
                    //hataImage.Add(item);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        resimByte = ms.ToArray();
                    }
                    Resimler resim = new Resimler();
                    resim.resimData = resimByte;
                    contextDb.Resimler.Add(resim);
                    contextDb.SaveChanges();

                    HataResimler hataResimler = new HataResimler();
                    hataResimler.resimID = resim.resimID;
                    hataResimler.hataID = hata.hataID;
                    contextDb.HataResimler.Add(hataResimler);
                    contextDb.SaveChanges();
                   
                }
                //veritabanına yeni hata oluşturuyoruz.
            }
            if (comboBoxMailGonder.SelectedItem != null)
            {
                string subject = textBoxHataTanim.Text;
                string body = "Hata Açıklama: " + textBoxAciklama.Text + "\n" + "Arıza Hata Kodu : " + hata.hataID;
                MailGonder((int)comboBoxMailGonder.SelectedValue, subject, body);
            }

            MessageBox.Show("Hata Mesajınız Sisteme İletilmiştir");

            Hatapictureboxes.Clear();
            tableLayoutPanel1.Controls.Clear();
            //Mail işlemleri
            
            
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string sorgu = textBoxSearch.Text;
            searchHata = contextDb.Hata.FirstOrDefault(a => a.hataID.ToString() == sorgu || a.hataAd == sorgu);

            if (searchHata != null)
            {
                var dosyaBilgisi = contextDb.Dosya.FirstOrDefault(a => a.dosyaID == searchHata.cozumDosyaID);
                if (dosyaBilgisi != null)
                {
                    buttonDosyaIndir.Enabled = true;
                    labelCozumDosyaAdi.Text = dosyaBilgisi.dosyaAdi;
                }
                else
                {
                    buttonDosyaIndir.Enabled = false;
                    labelCozumDosyaAdi.Text = "Çözüm Dosyası Yok";
                }
                textBoxCozum.Text = searchHata.hataCozum;
                textBoxCozumHataTanım.Text = searchHata.hataAd;
                var cozumResimler = contextDb.CozumResimler.Where(r => r.hataID == searchHata.hataID).ToList();
              
                if (cozumResimler != null)
                {
                    string deneme = "";
                    foreach (var item in cozumResimler)
                    {
                        deneme += item.Resimler.resimID + " ";
                        byte[] a = item.Resimler.resimData;
                        MemoryStream ms = new MemoryStream(a);
                        Image img = Image.FromStream(ms);
                        PictureBox picture = new PictureBox();
                        picture.MouseClick += Picture_MouseClick;
                        picture.SizeMode = PictureBoxSizeMode.StretchImage;
                        picture.Image = img;
                        tableLayoutPanel2.Controls.Add(picture);

                    }

                }
               
            }
            else
            {
                textBoxCozum.Text = "";
                textBoxCozumHataTanım.Text = "";
                labelCozumDosyaAdi.Text = "Çözüm Dosyası Yok";
                tableLayoutPanel2.Controls.Clear();
            }
        }
        //***********Resimleri Seçme Yeri*********////
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Resim Dosyası |*.jpeg;*.png;*jpg;*jpe";
            file.Title = "Resim Dosyası Seçiniz..";
            file.Multiselect = true;

            // file.FilterIndex = 2; // openfiledialog ekranını açıyor
            toolTip.IsBalloon = true;

            if (file.ShowDialog() == DialogResult.OK)
            {

                for (int i = 0; i < file.FileNames.Length; i++)
                {

                    PictureBox pictureBox = new PictureBox();

                    toolTip.SetToolTip(pictureBox, "Resmi Büyütmek İçin Tıklayınız.");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.MouseClick += Picture_MouseClick;

                    pictureBox.ImageLocation = file.FileNames[i];
                    Hatapictureboxes.Add(pictureBox);

                }
                tableLayoutPanel1.Controls.Clear();

                foreach (var item in Hatapictureboxes)
                {

                    tableLayoutPanel1.Controls.Add(item);

                }
            }



        }
        private void Picture_MouseClick(object sender, EventArgs e)
        {
            using (Form form = new Form())
            {

                form.StartPosition = FormStartPosition.CenterScreen;

                PictureBox pb = new PictureBox();

                pb.Dock = DockStyle.Fill;
                pb.Image = ((PictureBox)sender).Image;
                pb.SizeMode = PictureBoxSizeMode.AutoSize;
                form.Size = pb.Size;
                form.Controls.Add(pb);
                form.ShowDialog();
            }
            sender.ToString();
            e.ToString();
        }
        private void textBoxAciklama_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxAciklama.Text == null)
                e.Cancel = true;
        }
        //Kisiler tablosuna kisi ekliyoruz
        #region KisiEkle
        private void buttonKisiEkle_Click(object sender, EventArgs e)
        {
            Kisiler kisi = new Kisiler();
            kisi.kisiAd = textBoxAd.Text;
            kisi.kisiSoyad = textBoxSoyad.Text;
            kisi.kisiTel = textBoxTelNo.Text;
            kisi.kisiMail = textBoxEmail.Text;
            contextDb.Kisiler.Add(kisi);
            int durum = contextDb.SaveChanges();
            if (durum > 0)
            {
                MessageBox.Show("Kişi Eklenmiştir");
                KisiDoldur(comboBoxGonderenKisiler);
                KisiDoldur(comboBoxMailGonder);
                OtoDoldurmaText();
            }
        }
        #endregion
      
        #region Kisi Ekleme Silme Güncelleme İşlemleri
        Kisiler kisi;
        private void textBoxKisiArama_TextChanged(object sender, EventArgs e)
        {
            kisi = contextDb.Kisiler.FirstOrDefault(x => x.kisiAd.ToString() == textBoxKisiArama.Text);

            if (kisi != null)
            {
                textBoxAd.Text = kisi.kisiAd;
                textBoxSoyad.Text = kisi.kisiSoyad;
                textBoxTelNo.Text = kisi.kisiTel;
                textBoxEmail.Text = kisi.kisiMail;
            }
        }

        private void buttonKisiGuncelle_Click(object sender, EventArgs e)
        {
            // var kisi = contextDb.Kisiler.FirstOrDefault(x => x.kisiAd.ToString() == textBoxKisiArama.Text);
            if (kisi != null)
            {
                kisi.kisiAd = textBoxAd.Text;
                kisi.kisiSoyad = textBoxSoyad.Text;
                kisi.kisiTel = textBoxTelNo.Text;
                kisi.kisiMail = textBoxEmail.Text;
                int durum = contextDb.SaveChanges();
                if (durum > 0)
                {
                    MessageBox.Show(kisi.kisiAd + " " + kisi.kisiSoyad + " Güncellenmiştir.");
                }
            }
        }
        private void buttonKisiSil_Click(object sender, EventArgs e)
        {
            contextDb.Kisiler.Remove(kisi);
            int durum = contextDb.SaveChanges();
            if (durum > 0)
            {
                MessageBox.Show(kisi.kisiAd + " " + kisi.kisiSoyad + " Silinmiştir.");
                kisiTextleriSil();
                OtoDoldurmaText();
            }

        }
        public void OtoDoldurmaText()
        {
            var kisilerSearch = contextDb.Kisiler.ToList();
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            foreach (var item in kisilerSearch)
            {
                autoComplete.Add(item.kisiAd);
            }
            textBoxKisiArama.AutoCompleteCustomSource = autoComplete;
            textBoxKisiArama.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxKisiArama.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }    
        #endregion
        #region dataGridViewLeri Doldurma
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

            if (e.TabPageIndex == 4)
            {
                TumHatalariListele(); //Sistemdeki bütün hataları listeler
            }
            if (e.TabPageIndex == 2)
            {
                OtoDoldurmaText();
            }
            if (e.TabPageIndex == 3)
            {
                TumCozumleriListele();

            }
        }
        #endregion
        private void buttonCozumGonder_Click(object sender, EventArgs e)
        {
            byte[] DosyaBytes;
            if (DataGridViewSelectGlobalHata != null)
            {

                DataGridViewSelectGlobalHata.hataCozum = textBoxCozumAciklama.Text;
                DataGridViewSelectGlobalHata.cozumVarmi = true;
                DataGridViewSelectGlobalHata.cozumTarihi = DateTime.Now;

                if (dosya != null)
                {
                    System.IO.FileInfo ff = new System.IO.FileInfo(dosya.FileName);
                    DosyaBytes = System.IO.File.ReadAllBytes(dosya.FileName);
                    Dosya dfile = new Dosya();
                    dfile.dosyaAdi = dosya.SafeFileName;
                    dfile.dosyaData = DosyaBytes;
                    dfile.dosyaFormat = ff.Extension;
                    contextDb.Dosya.Add(dfile);
                    int durum = contextDb.SaveChanges();
                    if (durum > 0)
                    {
                        DataGridViewSelectGlobalHata.cozumDosyaID = dfile.dosyaID;
                    }




                }

                int a = contextDb.SaveChanges();
                byte[] resimByte = null;
                foreach (var item in Cozumpictureboxes)
                {
                    Image img = item.Image;
                    //hataImage.Add(item);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        resimByte = ms.ToArray();
                    }
                    Resimler resim = new Resimler();
                    resim.resimData = resimByte;
                    contextDb.Resimler.Add(resim);
                    contextDb.SaveChanges();

                    CozumResimler cozumResimler = new CozumResimler();
                    cozumResimler.resimID = resim.resimID;
                    cozumResimler.hataID = DataGridViewSelectGlobalHata.hataID;
                    contextDb.CozumResimler.Add(cozumResimler);
                    contextDb.SaveChanges();

                }

                if (a > 0)
                {
                    MessageBox.Show("Cözümünüz Sisteme eklenmiştir");
                    string konu = "Hata Kodu: "+ DataGridViewSelectGlobalHata.hataID+" olan "+ textBoxCozumTanım.Text+" Adlı Arızanın Çözümü";
                    string govde = "Çözüm Açıklama :"+ textBoxCozumAciklama.Text+"\n Daha detalı bilgiye, çözüm dosyası ve çözüm resimlerine Sanlab Arıza Tespit Sistemi Programının çözüm ara kısmından hata Kodunu Aratarak ulaşabilirsiniz.";
                    MailGonder(DataGridViewSelectGlobalHata.Kisiler.kisiID, konu, govde);
                    TumCozumleriListele();
                }
            }

            CozumBolumunuTemizle();

        }
        private void dataGridViewCozumEkle_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tableLayoutPanel4.Controls.Clear();
            string id = dataGridViewCozumEkle.Rows[dataGridViewCozumEkle.CurrentRow.Index].Cells["Hata_Id"].Value.ToString();

            DataGridViewSelectGlobalHata = contextDb.Hata.FirstOrDefault(h => h.hataID.ToString() == id);

            textBoxCozumAciklama.Text = DataGridViewSelectGlobalHata.hataCozum;
            textBoxCozumTanım.Text = DataGridViewSelectGlobalHata.hataAd;
            textBoxHataAciklama.Text = DataGridViewSelectGlobalHata.hataAciklama;
            if (DataGridViewSelectGlobalHata!=null)
            {

            var HataResimler = contextDb.HataResimler.Where(r => r.hataID == DataGridViewSelectGlobalHata.hataID).ToList();
            if (HataResimler != null)
            {

                foreach (var item in HataResimler)
                {

                    byte[] a = item.Resimler.resimData;
                    MemoryStream ms = new MemoryStream(a);
                    Image img = Image.FromStream(ms);
                    PictureBox picture = new PictureBox();
                    picture.MouseClick += Picture_MouseClick;
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Image = img;
                    tableLayoutPanel4.Controls.Add(picture);

                }

            }
            }
        }
        private void buttonCozumResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Resim Dosyası |*.jpeg;*.png;*jpg;*jpe";
            file.Title = "Resim Dosyası Seçiniz..";
            file.Multiselect = true;

            // file.FilterIndex = 2; // openfiledialog ekranını açıyor
            toolTip.IsBalloon = true;

            if (file.ShowDialog() == DialogResult.OK)
            {

                for (int i = 0; i < file.FileNames.Length; i++)
                {

                    PictureBox pictureBox = new PictureBox();

                    toolTip.SetToolTip(pictureBox, "Resmi Büyütmek İçin Tıklayınız.");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.MouseClick += Picture_MouseClick;

                    pictureBox.ImageLocation = file.FileNames[i];
                    Cozumpictureboxes.Add(pictureBox);

                }

                tableLayoutPanel3.Controls.Clear();
                foreach (var item in Cozumpictureboxes)
                {
                    tableLayoutPanel3.Controls.Add(item);
                }
            }
        }
        private void buttonDosyaEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = " Dosya |*.pdf;*.txt;*docx;*doc;*xslx;*xls;*rtf";
            file.Title = "Çözüm Dosyası Seçiniz..";
            file.Multiselect = false;

            if (file.ShowDialog() == DialogResult.OK)
            {
                // pdfFilePath = "c:/pdfdocuments/myfile.pdf";

                dosya = file;
                labelDosyaAdi.Text = file.SafeFileName;





            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            var dosyabyte = contextDb.Dosya.FirstOrDefault(a => a.dosyaID == searchHata.cozumDosyaID);
            save.Filter = "Çözüm Dosyası|*" + dosyabyte.dosyaFormat;
            save.FileName = dosyabyte.dosyaAdi;
            save.OverwritePrompt = true;
            // save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                if (searchHata != null)
                {

                    System.IO.File.WriteAllBytes(save.FileName, dosyabyte.dosyaData);
                }

                //db den çekilecek

                //  StreamWriter Kayit = new StreamWriter(save.FileName);

            }
        }
        void TumHatalariListele()
        {
           
            var tumHatalar = (from h in contextDb.Hata
                                                 select new
                                                 {
                                                     Hata_Id = h.hataID,
                                                     Hata_Adı = h.hataAd,
                                                     Hata_Müşteri = h.Musteri.musteriAd,
                                                     Hata_Açıklama = h.hataAciklama,
                                                     Kategori_Adı = h.Kategori.kategoriAd,
                                                     Gönderen_Ad = h.Kisiler.kisiAd,
                                                     Gönderen_Soyad = h.Kisiler.kisiSoyad,
                                                     Hata_Tarihi = h.hataTarih,
                                                     Çözüm_Açıklama = h.hataCozum,
                                                     Cözüm_Tarihi = h.cozumTarihi,
                                                     Cözüm_Varmı = (h.cozumVarmi == false || h.cozumVarmi == null) ? "Yok" : "Var"
                                                     //Cözüm_Tarih=h.cozumTarih
                                                 }).ToList();
            SortableBindingList<object> sbl = LINQExtension.ToSbl(tumHatalar);
            dataGridViewTumHatalar.DataSource = sbl;
           

            //this.dataGridViewTumHatalar.Sort(this.dataGridViewTumHatalar.Columns["Hata_Tarihi"], ListSortDirection.Ascending);
        }
        void TumCozumleriListele()
        {

            var tumCozumler = (from h in contextDb.Hata
                                                where h.cozumVarmi == false
                                                select new
                                                {
                                                    Hata_Id = h.hataID,
                                                    Hata_Adı = h.hataAd,
                                                    Hata_Müşteri=h.Musteri.musteriAd,
                                                    Hata_Açıklama = h.hataAciklama,
                                                    Kategori_Adı = h.Kategori.kategoriAd,
                                                    Gönderen_Ad = h.Kisiler.kisiAd,
                                                    Gönderen_Soyad = h.Kisiler.kisiSoyad,
                                                    Hata_Tarihi = h.hataTarih,
                                                    Cözüm_Tarihi = h.cozumTarihi,
                                                    Cözüm_Varmı = (h.cozumVarmi == false || h.cozumVarmi == null) ? "Yok" : "Var"
                                                    //Cözüm_Tarih=h.cozumTarih


                                                }).ToList();

            SortableBindingList<object> sbl = LINQExtension.ToSbl(tumCozumler);
            dataGridViewCozumEkle.DataSource = sbl;
        }
        void CozumBolumunuTemizle()
        {
            Cozumpictureboxes.Clear();
            tableLayoutPanel3.Controls.Clear();
            textBoxCozumTanım.Text = "";
            textBoxCozumAciklama.Text = "";
        }
        void kisiTextleriSil()
        {
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            textBoxTelNo.Text = "";
            textBoxEmail.Text = "";
            textBoxKisiArama.Text = "";
        }
        void KisiDoldur(ComboBox comboBox)
        {
            var KisiList = contextDb.Kisiler.ToList();

            comboBox.ValueMember = "kisiID";
            comboBox.DisplayMember = "fullName";
            comboBox.DataSource = KisiList;

        }
        void MailGonder(int kisiID,string konuText,string govdeText)
        {
            var kisi = contextDb.Kisiler.FirstOrDefault(x => x.kisiID == kisiID);

            var fromAddress = new MailAddress("sanlabhatasistemi@gmail.com", "Sanlab Arıza Tespit Sistemi");
            var toAddress = new MailAddress(kisi.kisiMail, kisi.kisiAd + " " + kisi.kisiSoyad);
            const string fromPassword = "sanlab123";
            

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = konuText,
                Body = govdeText
            })
            {
                smtp.Send(message);
            }


        }
       public void KategoriDoldur()
        {
            var kategoriList = contextDb.Kategori.ToList();
            comboBoxKategori.ValueMember = "kategoriID";
            comboBoxKategori.DisplayMember = "kategoriAd";
            comboBoxKategori.DataSource = kategoriList;
        }
       public void MusteriDoldur()
        {
            var musteriList = contextDb.Musteri.ToList();
            comboBoxMusteri.ValueMember = "musteriID";
            comboBoxMusteri.DisplayMember = "musteriAd";
            comboBoxMusteri.DataSource = musteriList;
        }
       // TextBox textBoxKategori = new TextBox();
        private void buttonKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriEkleForm form = new KategoriEkleForm();
            //Form form = new Form();
            //form.Text = "Kategori Ekle";
            //Button btnKategoriEkle = new Button();
            //btnKategoriEkle.Location = new System.Drawing.Point(108, 66);
            //btnKategoriEkle.Name = "buttonKategoriEkle";
            //btnKategoriEkle.Size = new System.Drawing.Size(75, 23);
            //btnKategoriEkle.TabIndex = 1;
            //btnKategoriEkle.Text = "Ekle";
            //btnKategoriEkle.UseVisualStyleBackColor = true;
            //btnKategoriEkle.Click += BtnKategoriEkle_Click;
            
            //textBoxKategori.Location = new System.Drawing.Point(83, 30);
            //textBoxKategori.Name = "textBoxKategoriEkle";
            //textBoxKategori.Size = new System.Drawing.Size(100, 20);
            //textBoxKategori.TabIndex = 0;
            //form.Controls.Add(btnKategoriEkle);
            //form.Controls.Add(textBoxKategori);
            form.ShowDialog();
          
           // form.FormClosing += Form_FormClosing;


        }
        private void buttonMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkleForm mform = new MusteriEkleForm();
            mform.ShowDialog();
        }

        private void tabPageCozumEkle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCozumEkle_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void tabPageHata_Click(object sender, EventArgs e)
        {

        }
    }
}
