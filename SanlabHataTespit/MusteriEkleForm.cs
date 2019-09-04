using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanlabHataTespit
{
    public partial class MusteriEkleForm : Form
    {
        SanlabHataTespitVTEntities contextDb = new SanlabHataTespitVTEntities();
        public MusteriEkleForm()
        {
            InitializeComponent();
        }

        private void buttonMusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.musteriAd = textBoxMusteriAd.Text;
            musteri.musteriAdres = textBoxMusteriAdress.Text;
            musteri.musteriMail = textBoxMusteriMail.Text;
            musteri.musteriTel = textBoxMusteriTelefon.Text;
            contextDb.Musteri.Add(musteri);
           int durum= contextDb.SaveChanges();
            if (durum>0)
            {
                MessageBox.Show("Yeni Müşteri Eklendi");
                var mfrm = (Form1)Application.OpenForms["Form1"];
                if (mfrm != null)
                    mfrm.MusteriDoldur();
            }
        }
    }
}
