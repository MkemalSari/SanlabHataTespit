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
    
    public partial class KategoriEkleForm : Form
    {
        SanlabHataTespitVTEntities contextDb = new SanlabHataTespitVTEntities();
        public KategoriEkleForm()
        {
            InitializeComponent();
        }

        private void FormResim_Load(object sender, EventArgs e)
        {

        }

        private void buttonKategoriEkle_Click(object sender, EventArgs e)
        {
            if (textBoxKategoriEkle.Text!=null)
            {
                Kategori kategori = new Kategori();
                kategori.kategoriAd = textBoxKategoriEkle.Text;

                contextDb.Kategori.Add(kategori);
                int d = contextDb.SaveChanges();
                if (d>0)
                {
                    MessageBox.Show("Kategori Eklendi");
                    var mfrm = (Form1)Application.OpenForms["Form1"];
                    if (mfrm != null)
                        mfrm.KategoriDoldur();
                }
            }
           
        }

        private void KategoriEkleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
