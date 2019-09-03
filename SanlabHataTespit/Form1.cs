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
        byte[] DosyaBytes;

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
            var kategoriList = contextDb.Kategori.ToList();
            comboBoxKategori.ValueMember = "kategoriID";
            comboBoxKategori.DisplayMember = "kategoriAd";
            comboBoxKategori.DataSource = kategoriList;

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
                    var durum = contextDb.SaveChanges();
                    if (durum > 0)
                    {
                        MessageBox.Show("Hata Mesajınız Sisteme İletilmiştir");

                    }
                }
                //veritabanına yeni hata oluşturuyoruz.
            }
            Hatapictureboxes.Clear();
            tableLayoutPanel1.Controls.Clear();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string sorgu = textBoxSearch.Text;
            var search = contextDb.Hata.FirstOrDefault(a => a.hataID.ToString() == sorgu || a.hataAd == sorgu);

            if (search != null)
            {
                textBoxCozum.Text = search.hataCozum;
                textBoxCozumHataTanım.Text = search.hataAd;
                var cozumResimler = contextDb.CozumResimler.Where(r => r.hataID == search.hataID).ToList();
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
                else
                {

                }
            }
            else
            {
                textBoxCozum.Text = "";
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

        #region MailGönderme
        private void button2_Click(object sender, EventArgs e)
        {


            if (comboBoxMailGonder.SelectedItem != null)
            {
                var kisi = contextDb.Kisiler.FirstOrDefault(x => x.kisiID == comboBoxMailGonder.SelectedIndex + 1);

                var fromAddress = new MailAddress("sanlabhatasistemi@gmail.com", "Sanlab Hata Sistemi");
                var toAddress = new MailAddress(kisi.kisiMail, kisi.kisiAd + " " + kisi.kisiSoyad);
                const string fromPassword = "sanlab123";
                string subject = textBoxHataTanim.Text;
                string body = textBoxAciklama.Text;

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
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }

        }


        #endregion
        public void KisiDoldur(ComboBox comboBox)
        {
            var KisiList = contextDb.Kisiler.ToList();

            comboBox.ValueMember = "kisiID";
            comboBox.DisplayMember = "fullName";
            comboBox.DataSource = KisiList;

        }

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

        public void kisiTextleriSil()
        {
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            textBoxTelNo.Text = "";
            textBoxEmail.Text = "";
            textBoxKisiArama.Text = "";
        }
        #endregion


        #region dataGridViewLeri Doldurma
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

            if (e.TabPageIndex == 4)
            {
                dataGridViewTumHatalar.DataSource = (from h in contextDb.Hata
                                                     select new
                                                     {
                                                         Hata_Id = h.hataID,
                                                         Hata_Adı = h.hataAd,
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
            }
            if (e.TabPageIndex == 2)
            {
                OtoDoldurmaText();
            }
            if (e.TabPageIndex == 3)
            {
                dataGridViewCozumEkle.DataSource = (from h in contextDb.Hata
                                                    where h.cozumVarmi == false
                                                    select new
                                                    {
                                                        Hata_Id = h.hataID,
                                                        Hata_Adı = h.hataAd,
                                                        Hata_Açıklama = h.hataAciklama,
                                                        Kategori_Adı = h.Kategori.kategoriAd,
                                                        Gönderen_Ad = h.Kisiler.kisiAd,
                                                        Gönderen_Soyad = h.Kisiler.kisiSoyad,
                                                        Hata_Tarihi = h.hataTarih,
                                                        Cözüm_Tarihi = h.cozumTarihi,
                                                        Cözüm_Varmı = (h.cozumVarmi == false || h.cozumVarmi == null) ? "Yok" : "Var"
                                                        //Cözüm_Tarih=h.cozumTarih


                                                    }).ToList();
            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            KategoriEkleForm form = new KategoriEkleForm();
            form.ShowDialog();
        }
       
        private void buttonCozumGonder_Click(object sender, EventArgs e)
        {
            if (DataGridViewSelectGlobalHata != null)
            {

                DataGridViewSelectGlobalHata.hataCozum = textBoxCozumAciklama.Text;
                DataGridViewSelectGlobalHata.cozumVarmi = true;
                DataGridViewSelectGlobalHata.cozumTarihi = DateTime.Now;
                DataGridViewSelectGlobalHata.cozumDosya = DosyaBytes;
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

                }
            }

            Cozumpictureboxes.Clear();
            tableLayoutPanel3.Controls.Clear();
        }
        
        private void dataGridViewCozumEkle_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dataGridViewCozumEkle.Rows[dataGridViewCozumEkle.CurrentRow.Index].Cells["Hata_Id"].Value.ToString();

            DataGridViewSelectGlobalHata = contextDb.Hata.FirstOrDefault(h => h.hataID.ToString() == id);

            textBoxCozumAciklama.Text = DataGridViewSelectGlobalHata.hataCozum;
            textBoxCozumTanım.Text = DataGridViewSelectGlobalHata.hataAd;
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
       
        private void dataGridViewTumHatalar_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.Programmatic;
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
                DosyaBytes = System.IO.File.ReadAllBytes(file.FileName);
             
                labelDosyaAdi.Text = file.SafeFileName;





            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
           // save.Filter = "Metin Dosyası|*.txt";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllBytes(save.FileName, DosyaBytes);
              //  StreamWriter Kayit = new StreamWriter(save.FileName);
              
            }
        }
    }
}
