namespace SanlabHataTespit
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBoxHataAdi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCozum = new System.Windows.Forms.TextBox();
            this.pictureBoxHata = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCozum = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxCozum = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çözümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCozum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxCozum.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(73, 296);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 0;
            this.buttonKaydet.Text = "Gönder";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxKategori.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(73, 21);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(156, 21);
            this.comboBoxKategori.TabIndex = 1;
            this.comboBoxKategori.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSearch.Location = new System.Drawing.Point(84, 23);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(170, 26);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ara";
            // 
            // comboBoxHataAdi
            // 
            this.comboBoxHataAdi.FormattingEnabled = true;
            this.comboBoxHataAdi.Location = new System.Drawing.Point(73, 48);
            this.comboBoxHataAdi.Name = "comboBoxHataAdi";
            this.comboBoxHataAdi.Size = new System.Drawing.Size(156, 21);
            this.comboBoxHataAdi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hata Tanım";
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(73, 85);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(193, 95);
            this.textBoxAciklama.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Çözüm";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxCozum
            // 
            this.textBoxCozum.Location = new System.Drawing.Point(61, 88);
            this.textBoxCozum.Multiline = true;
            this.textBoxCozum.Name = "textBoxCozum";
            this.textBoxCozum.Size = new System.Drawing.Size(193, 95);
            this.textBoxCozum.TabIndex = 7;
            // 
            // pictureBoxHata
            // 
            this.pictureBoxHata.Location = new System.Drawing.Point(73, 186);
            this.pictureBoxHata.Name = "pictureBoxHata";
            this.pictureBoxHata.Size = new System.Drawing.Size(92, 90);
            this.pictureBoxHata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHata.TabIndex = 8;
            this.pictureBoxHata.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Resim";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::SanlabHataTespit.Properties.Resources.icons8_search_24;
            this.pictureBox2.Location = new System.Drawing.Point(61, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxCozum
            // 
            this.pictureBoxCozum.Location = new System.Drawing.Point(61, 189);
            this.pictureBoxCozum.Name = "pictureBoxCozum";
            this.pictureBoxCozum.Size = new System.Drawing.Size(138, 104);
            this.pictureBoxCozum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCozum.TabIndex = 9;
            this.pictureBoxCozum.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxCozum);
            this.groupBox1.Controls.Add(this.textBoxAciklama);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxHataAdi);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxKategori);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBoxHata);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 344);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hata İlet";
            this.groupBox1.Visible = false;
            // 
            // groupBoxCozum
            // 
            this.groupBoxCozum.Controls.Add(this.pictureBoxCozum);
            this.groupBoxCozum.Controls.Add(this.pictureBox2);
            this.groupBoxCozum.Controls.Add(this.textBoxSearch);
            this.groupBoxCozum.Controls.Add(this.textBoxCozum);
            this.groupBoxCozum.Controls.Add(this.label2);
            this.groupBoxCozum.Controls.Add(this.label6);
            this.groupBoxCozum.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCozum.Name = "groupBoxCozum";
            this.groupBoxCozum.Size = new System.Drawing.Size(284, 345);
            this.groupBoxCozum.TabIndex = 14;
            this.groupBoxCozum.TabStop = false;
            this.groupBoxCozum.Text = "Çözüm Ara";
            this.groupBoxCozum.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hataToolStripMenuItem,
            this.çözümToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hataToolStripMenuItem
            // 
            this.hataToolStripMenuItem.Name = "hataToolStripMenuItem";
            this.hataToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hataToolStripMenuItem.Text = "Hata";
            this.hataToolStripMenuItem.Click += new System.EventHandler(this.hataToolStripMenuItem_Click);
            // 
            // çözümToolStripMenuItem
            // 
            this.çözümToolStripMenuItem.Name = "çözümToolStripMenuItem";
            this.çözümToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.çözümToolStripMenuItem.Text = "Çözüm";
            this.çözümToolStripMenuItem.Click += new System.EventHandler(this.çözümToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCozum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxCozum.ResumeLayout(false);
            this.groupBoxCozum.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboBoxHataAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCozum;
        private System.Windows.Forms.PictureBox pictureBoxHata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxCozum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxCozum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çözümToolStripMenuItem;
    }
}

