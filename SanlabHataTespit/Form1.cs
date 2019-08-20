using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanlabHataTespit
{
    public partial class Form1 : Form
    {
        SanlabHataTespitVTEntities contextDb = new SanlabHataTespitVTEntities();
        byte[] resimByte = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxHataAdi.Items.Clear();
            var hataList = contextDb.Hata.Where(a => a.kategoriID == comboBoxKategori.SelectedIndex+1);
            foreach (var item in hataList)
            {
                comboBoxHataAdi.Items.Add(item.hataAd);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          var kategoriList=  contextDb.Kategori.ToList();
            foreach (var item in kategoriList)
            {
                comboBoxKategori.Items.Add(item.KategoriAd);
            }


            var search = contextDb.Hata.ToList();
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            foreach (var item in search)
            {
                autoComplete.Add(item.hataAd);
            }
            textBoxSearch.AutoCompleteCustomSource = autoComplete;
            textBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //veritabanına yeni hata oluşturuyoruz.
            Hata hata = new Hata();
            hata.hataAd = comboBoxHataAdi.Text;
            hata.hataAciklama = textBoxAciklama.Text;
            hata.kategoriID = comboBoxKategori.SelectedIndex+1;
            hata.hataCozum = null;
            hata.hataResim = resimByte;
            contextDb.Hata.Add(hata);
            var durum= contextDb.SaveChanges();
            if (durum>0)
            {
                MessageBox.Show("Hata Mesajınız Sisteme İletilmiştir");
            }
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string sorgu = textBoxSearch.Text;
            var search = contextDb.Hata.FirstOrDefault(a=> a.hataAd==(sorgu));

            if (search!=null)
            {
                textBoxCozum.Text = search.hataCozum;
                if (search.hataResim!=null)
                {
                    MemoryStream ms = new MemoryStream(search.hataResim);
                    Image img = Image.FromStream(ms);
                    pictureBoxCozum.Image = img;
                }
               
            }
            else
            {
                textBoxCozum.Text = "";
            }
           







        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Resim Dosyası |*.jpeg;*.png;*jpg;*jpe";
            file.Title = "Resim Dosyası Seçiniz..";

            // file.FilterIndex = 2; // openfiledialog ekranını açıyor


            if (file.ShowDialog() == DialogResult.OK)
            {
                // dosya seçildi ise
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;
                pictureBoxHata.ImageLocation = DosyaYolu;
                Image img = Image.FromFile(DosyaYolu);
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    resimByte = ms.ToArray();
                }
            }

           



        }

        private void hataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBoxCozum.Visible = false;
        }

        private void çözümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBoxCozum.Visible = true;
        }
    }
}
