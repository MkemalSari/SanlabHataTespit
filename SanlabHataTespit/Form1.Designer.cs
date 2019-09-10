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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCozum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMusteriEkle = new System.Windows.Forms.Button();
            this.buttonKategoriEkle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxHataTanim = new System.Windows.Forms.TextBox();
            this.comboBoxMailGonder = new System.Windows.Forms.ComboBox();
            this.comboBoxGonderenKisiler = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMusteri = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBoxCozum = new System.Windows.Forms.GroupBox();
            this.labelCozumDosyaAdi = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonDosyaIndir = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxCozumHataTanım = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sanlabHataTespitVTDataSet = new SanlabHataTespit.SanlabHataTespitVTDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHata = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPageCozum = new System.Windows.Forms.TabPage();
            this.tabPageKisi = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxKisiArama = new System.Windows.Forms.TextBox();
            this.buttonKisiSil = new System.Windows.Forms.Button();
            this.buttonKisiGuncelle = new System.Windows.Forms.Button();
            this.buttonKisiEkle = new System.Windows.Forms.Button();
            this.textBoxTelNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageCozumEkle = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxCozumHataAra = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxHataAciklama = new System.Windows.Forms.TextBox();
            this.textBoxCozumTanım = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCozumGonder = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxCozumAciklama = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonCozumResimEkle = new System.Windows.Forms.Button();
            this.buttonDosyaEkle = new System.Windows.Forms.Button();
            this.labelDosyaAdi = new System.Windows.Forms.Label();
            this.dataGridViewCozumEkle = new System.Windows.Forms.DataGridView();
            this.tabPageHatalar = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBoxTumHatalarKategori = new System.Windows.Forms.ComboBox();
            this.dataGridViewTumHatalar = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBoxCozum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanlabHataTespitVTDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageHata.SuspendLayout();
            this.tabPageCozum.SuspendLayout();
            this.tabPageKisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageCozumEkle.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCozumEkle)).BeginInit();
            this.tabPageHatalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumHatalar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(73, 422);
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
            this.comboBoxKategori.Size = new System.Drawing.Size(167, 21);
            this.comboBoxKategori.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori      :";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSearch.Location = new System.Drawing.Point(107, 23);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(170, 26);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ara :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hata Tanım :";
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(73, 151);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(193, 95);
            this.textBoxAciklama.TabIndex = 7;
            this.textBoxAciklama.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAciklama_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Açıklama    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Çözüm :";
            // 
            // textBoxCozum
            // 
            this.textBoxCozum.Location = new System.Drawing.Point(84, 145);
            this.textBoxCozum.Multiline = true;
            this.textBoxCozum.Name = "textBoxCozum";
            this.textBoxCozum.Size = new System.Drawing.Size(193, 95);
            this.textBoxCozum.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Resim Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMusteriEkle);
            this.groupBox1.Controls.Add(this.buttonKategoriEkle);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.textBoxHataTanim);
            this.groupBox1.Controls.Add(this.textBoxAciklama);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxMailGonder);
            this.groupBox1.Controls.Add(this.comboBoxGonderenKisiler);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxMusteri);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.comboBoxKategori);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 444);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hata İlet";
            // 
            // buttonMusteriEkle
            // 
            this.buttonMusteriEkle.Location = new System.Drawing.Point(246, 46);
            this.buttonMusteriEkle.Name = "buttonMusteriEkle";
            this.buttonMusteriEkle.Size = new System.Drawing.Size(20, 23);
            this.buttonMusteriEkle.TabIndex = 12;
            this.buttonMusteriEkle.Text = "+";
            this.buttonMusteriEkle.UseVisualStyleBackColor = true;
            this.buttonMusteriEkle.Click += new System.EventHandler(this.buttonMusteriEkle_Click);
            // 
            // buttonKategoriEkle
            // 
            this.buttonKategoriEkle.Location = new System.Drawing.Point(246, 19);
            this.buttonKategoriEkle.Name = "buttonKategoriEkle";
            this.buttonKategoriEkle.Size = new System.Drawing.Size(20, 23);
            this.buttonKategoriEkle.TabIndex = 12;
            this.buttonKategoriEkle.Text = "+";
            this.buttonKategoriEkle.UseVisualStyleBackColor = true;
            this.buttonKategoriEkle.Click += new System.EventHandler(this.buttonKategoriEkle_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(73, 252);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 108);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxHataTanim
            // 
            this.textBoxHataTanim.Location = new System.Drawing.Point(73, 99);
            this.textBoxHataTanim.Multiline = true;
            this.textBoxHataTanim.Name = "textBoxHataTanim";
            this.textBoxHataTanim.Size = new System.Drawing.Size(193, 46);
            this.textBoxHataTanim.TabIndex = 7;
            this.textBoxHataTanim.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAciklama_Validating);
            // 
            // comboBoxMailGonder
            // 
            this.comboBoxMailGonder.FormattingEnabled = true;
            this.comboBoxMailGonder.Location = new System.Drawing.Point(73, 395);
            this.comboBoxMailGonder.Name = "comboBoxMailGonder";
            this.comboBoxMailGonder.Size = new System.Drawing.Size(156, 21);
            this.comboBoxMailGonder.TabIndex = 6;
            // 
            // comboBoxGonderenKisiler
            // 
            this.comboBoxGonderenKisiler.FormattingEnabled = true;
            this.comboBoxGonderenKisiler.Location = new System.Drawing.Point(73, 72);
            this.comboBoxGonderenKisiler.Name = "comboBoxGonderenKisiler";
            this.comboBoxGonderenKisiler.Size = new System.Drawing.Size(167, 21);
            this.comboBoxGonderenKisiler.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-3, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mail Gönder :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gönderen Kişi :";
            // 
            // comboBoxMusteri
            // 
            this.comboBoxMusteri.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxMusteri.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxMusteri.FormattingEnabled = true;
            this.comboBoxMusteri.Location = new System.Drawing.Point(73, 48);
            this.comboBoxMusteri.Name = "comboBoxMusteri";
            this.comboBoxMusteri.Size = new System.Drawing.Size(167, 21);
            this.comboBoxMusteri.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Müşteri    :";
            // 
            // groupBoxCozum
            // 
            this.groupBoxCozum.Controls.Add(this.labelCozumDosyaAdi);
            this.groupBoxCozum.Controls.Add(this.label20);
            this.groupBoxCozum.Controls.Add(this.buttonDosyaIndir);
            this.groupBoxCozum.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxCozum.Controls.Add(this.pictureBox2);
            this.groupBoxCozum.Controls.Add(this.textBoxSearch);
            this.groupBoxCozum.Controls.Add(this.textBoxCozumHataTanım);
            this.groupBoxCozum.Controls.Add(this.textBoxCozum);
            this.groupBoxCozum.Controls.Add(this.label11);
            this.groupBoxCozum.Controls.Add(this.label2);
            this.groupBoxCozum.Controls.Add(this.label6);
            this.groupBoxCozum.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCozum.Name = "groupBoxCozum";
            this.groupBoxCozum.Size = new System.Drawing.Size(335, 457);
            this.groupBoxCozum.TabIndex = 14;
            this.groupBoxCozum.TabStop = false;
            this.groupBoxCozum.Text = "Çözüm Ara";
            // 
            // labelCozumDosyaAdi
            // 
            this.labelCozumDosyaAdi.AutoSize = true;
            this.labelCozumDosyaAdi.Location = new System.Drawing.Point(74, 377);
            this.labelCozumDosyaAdi.Name = "labelCozumDosyaAdi";
            this.labelCozumDosyaAdi.Size = new System.Drawing.Size(0, 13);
            this.labelCozumDosyaAdi.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 377);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "Dosya Adı :";
            // 
            // buttonDosyaIndir
            // 
            this.buttonDosyaIndir.Location = new System.Drawing.Point(202, 415);
            this.buttonDosyaIndir.Name = "buttonDosyaIndir";
            this.buttonDosyaIndir.Size = new System.Drawing.Size(75, 23);
            this.buttonDosyaIndir.TabIndex = 16;
            this.buttonDosyaIndir.Text = "Dosya İndir";
            this.buttonDosyaIndir.UseVisualStyleBackColor = true;
            this.buttonDosyaIndir.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(84, 255);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(193, 108);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::SanlabHataTespit.Properties.Resources.icons8_search_24;
            this.pictureBox2.Location = new System.Drawing.Point(84, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxCozumHataTanım
            // 
            this.textBoxCozumHataTanım.Location = new System.Drawing.Point(84, 76);
            this.textBoxCozumHataTanım.Multiline = true;
            this.textBoxCozumHataTanım.Name = "textBoxCozumHataTanım";
            this.textBoxCozumHataTanım.Size = new System.Drawing.Size(193, 44);
            this.textBoxCozumHataTanım.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Hata Tanım :";
            // 
            // sanlabHataTespitVTDataSet
            // 
            this.sanlabHataTespitVTDataSet.DataSetName = "SanlabHataTespitVTDataSet";
            this.sanlabHataTespitVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHata);
            this.tabControl1.Controls.Add(this.tabPageCozum);
            this.tabControl1.Controls.Add(this.tabPageKisi);
            this.tabControl1.Controls.Add(this.tabPageCozumEkle);
            this.tabControl1.Controls.Add(this.tabPageHatalar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 535);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPageHata
            // 
            this.tabPageHata.Controls.Add(this.label13);
            this.tabPageHata.Controls.Add(this.groupBox1);
            this.tabPageHata.Location = new System.Drawing.Point(4, 22);
            this.tabPageHata.Name = "tabPageHata";
            this.tabPageHata.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHata.Size = new System.Drawing.Size(566, 509);
            this.tabPageHata.TabIndex = 0;
            this.tabPageHata.Text = "Hata Bildir";
            this.tabPageHata.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 616);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Bir Stajer İşbirliği Yapımıdır.";
            // 
            // tabPageCozum
            // 
            this.tabPageCozum.Controls.Add(this.groupBoxCozum);
            this.tabPageCozum.Location = new System.Drawing.Point(4, 22);
            this.tabPageCozum.Name = "tabPageCozum";
            this.tabPageCozum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCozum.Size = new System.Drawing.Size(566, 509);
            this.tabPageCozum.TabIndex = 1;
            this.tabPageCozum.Text = "Çözüm Ara";
            this.tabPageCozum.UseVisualStyleBackColor = true;
            // 
            // tabPageKisi
            // 
            this.tabPageKisi.Controls.Add(this.pictureBox1);
            this.tabPageKisi.Controls.Add(this.textBoxKisiArama);
            this.tabPageKisi.Controls.Add(this.buttonKisiSil);
            this.tabPageKisi.Controls.Add(this.buttonKisiGuncelle);
            this.tabPageKisi.Controls.Add(this.buttonKisiEkle);
            this.tabPageKisi.Controls.Add(this.textBoxTelNo);
            this.tabPageKisi.Controls.Add(this.label10);
            this.tabPageKisi.Controls.Add(this.textBoxEmail);
            this.tabPageKisi.Controls.Add(this.label9);
            this.tabPageKisi.Controls.Add(this.textBoxSoyad);
            this.tabPageKisi.Controls.Add(this.label8);
            this.tabPageKisi.Controls.Add(this.textBoxAd);
            this.tabPageKisi.Controls.Add(this.label14);
            this.tabPageKisi.Controls.Add(this.label7);
            this.tabPageKisi.Location = new System.Drawing.Point(4, 22);
            this.tabPageKisi.Name = "tabPageKisi";
            this.tabPageKisi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKisi.Size = new System.Drawing.Size(566, 509);
            this.tabPageKisi.TabIndex = 2;
            this.tabPageKisi.Text = "Kişiler";
            this.tabPageKisi.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SanlabHataTespit.Properties.Resources.icons8_search_24;
            this.pictureBox1.Location = new System.Drawing.Point(161, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxKisiArama
            // 
            this.textBoxKisiArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKisiArama.Location = new System.Drawing.Point(184, 42);
            this.textBoxKisiArama.Name = "textBoxKisiArama";
            this.textBoxKisiArama.Size = new System.Drawing.Size(170, 26);
            this.textBoxKisiArama.TabIndex = 9;
            this.textBoxKisiArama.TextChanged += new System.EventHandler(this.textBoxKisiArama_TextChanged);
            // 
            // buttonKisiSil
            // 
            this.buttonKisiSil.Location = new System.Drawing.Point(346, 175);
            this.buttonKisiSil.Name = "buttonKisiSil";
            this.buttonKisiSil.Size = new System.Drawing.Size(75, 23);
            this.buttonKisiSil.TabIndex = 2;
            this.buttonKisiSil.Text = "Sil";
            this.buttonKisiSil.UseVisualStyleBackColor = true;
            this.buttonKisiSil.Click += new System.EventHandler(this.buttonKisiSil_Click);
            // 
            // buttonKisiGuncelle
            // 
            this.buttonKisiGuncelle.Location = new System.Drawing.Point(346, 146);
            this.buttonKisiGuncelle.Name = "buttonKisiGuncelle";
            this.buttonKisiGuncelle.Size = new System.Drawing.Size(75, 23);
            this.buttonKisiGuncelle.TabIndex = 2;
            this.buttonKisiGuncelle.Text = "Güncelle";
            this.buttonKisiGuncelle.UseVisualStyleBackColor = true;
            this.buttonKisiGuncelle.Click += new System.EventHandler(this.buttonKisiGuncelle_Click);
            // 
            // buttonKisiEkle
            // 
            this.buttonKisiEkle.Location = new System.Drawing.Point(346, 114);
            this.buttonKisiEkle.Name = "buttonKisiEkle";
            this.buttonKisiEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonKisiEkle.TabIndex = 2;
            this.buttonKisiEkle.Text = "Ekle";
            this.buttonKisiEkle.UseVisualStyleBackColor = true;
            this.buttonKisiEkle.Click += new System.EventHandler(this.buttonKisiEkle_Click);
            // 
            // textBoxTelNo
            // 
            this.textBoxTelNo.Location = new System.Drawing.Point(217, 172);
            this.textBoxTelNo.Name = "textBoxTelNo";
            this.textBoxTelNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelNo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Telefon Numarası";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(217, 198);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "E-mail Adresi";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(217, 143);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoyad.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Soyad";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(217, 117);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxAd.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Kişi Arama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ad";
            // 
            // tabPageCozumEkle
            // 
            this.tabPageCozumEkle.Controls.Add(this.groupBox3);
            this.tabPageCozumEkle.Controls.Add(this.groupBox2);
            this.tabPageCozumEkle.Controls.Add(this.labelDosyaAdi);
            this.tabPageCozumEkle.Controls.Add(this.dataGridViewCozumEkle);
            this.tabPageCozumEkle.Location = new System.Drawing.Point(4, 22);
            this.tabPageCozumEkle.Name = "tabPageCozumEkle";
            this.tabPageCozumEkle.Size = new System.Drawing.Size(566, 509);
            this.tabPageCozumEkle.TabIndex = 4;
            this.tabPageCozumEkle.Text = "Çözüm Ekle";
            this.tabPageCozumEkle.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.textBoxCozumHataAra);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBoxHataAciklama);
            this.groupBox3.Controls.Add(this.textBoxCozumTanım);
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(9, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 164);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::SanlabHataTespit.Properties.Resources.icons8_search_24;
            this.pictureBox3.Location = new System.Drawing.Point(82, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxCozumHataAra
            // 
            this.textBoxCozumHataAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCozumHataAra.Location = new System.Drawing.Point(105, 13);
            this.textBoxCozumHataAra.Name = "textBoxCozumHataAra";
            this.textBoxCozumHataAra.Size = new System.Drawing.Size(177, 26);
            this.textBoxCozumHataAra.TabIndex = 9;
            this.textBoxCozumHataAra.TextChanged += new System.EventHandler(this.textBoxCozumHataAra_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(37, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Ara :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(287, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Hata Tanım";
            // 
            // textBoxHataAciklama
            // 
            this.textBoxHataAciklama.Location = new System.Drawing.Point(355, 47);
            this.textBoxHataAciklama.Multiline = true;
            this.textBoxHataAciklama.Name = "textBoxHataAciklama";
            this.textBoxHataAciklama.Size = new System.Drawing.Size(179, 107);
            this.textBoxHataAciklama.TabIndex = 3;
            // 
            // textBoxCozumTanım
            // 
            this.textBoxCozumTanım.Enabled = false;
            this.textBoxCozumTanım.Location = new System.Drawing.Point(355, 13);
            this.textBoxCozumTanım.Multiline = true;
            this.textBoxCozumTanım.Name = "textBoxCozumTanım";
            this.textBoxCozumTanım.Size = new System.Drawing.Size(179, 25);
            this.textBoxCozumTanım.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(82, 50);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 107);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(299, 47);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Açıklama";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(1, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Hata Resimleri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Controls.Add(this.buttonCozumGonder);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBoxCozumAciklama);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.buttonCozumResimEkle);
            this.groupBox2.Controls.Add(this.buttonDosyaEkle);
            this.groupBox2.Location = new System.Drawing.Point(8, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 221);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(98, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.49495F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.50505F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 103);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // buttonCozumGonder
            // 
            this.buttonCozumGonder.Location = new System.Drawing.Point(219, 190);
            this.buttonCozumGonder.Name = "buttonCozumGonder";
            this.buttonCozumGonder.Size = new System.Drawing.Size(136, 23);
            this.buttonCozumGonder.TabIndex = 2;
            this.buttonCozumGonder.Text = "Çözüm Gönder";
            this.buttonCozumGonder.UseVisualStyleBackColor = true;
            this.buttonCozumGonder.Click += new System.EventHandler(this.buttonCozumGonder_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Eklenen Dosya :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(316, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Çözüm";
            // 
            // textBoxCozumAciklama
            // 
            this.textBoxCozumAciklama.Location = new System.Drawing.Point(361, 19);
            this.textBoxCozumAciklama.Multiline = true;
            this.textBoxCozumAciklama.Name = "textBoxCozumAciklama";
            this.textBoxCozumAciklama.Size = new System.Drawing.Size(179, 103);
            this.textBoxCozumAciklama.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(10, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Çözüm Resimler";
            // 
            // buttonCozumResimEkle
            // 
            this.buttonCozumResimEkle.Location = new System.Drawing.Point(97, 128);
            this.buttonCozumResimEkle.Name = "buttonCozumResimEkle";
            this.buttonCozumResimEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonCozumResimEkle.TabIndex = 5;
            this.buttonCozumResimEkle.Text = "Resim Ekle";
            this.buttonCozumResimEkle.UseVisualStyleBackColor = true;
            this.buttonCozumResimEkle.Click += new System.EventHandler(this.buttonCozumResimEkle_Click);
            // 
            // buttonDosyaEkle
            // 
            this.buttonDosyaEkle.Location = new System.Drawing.Point(178, 128);
            this.buttonDosyaEkle.Name = "buttonDosyaEkle";
            this.buttonDosyaEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonDosyaEkle.TabIndex = 5;
            this.buttonDosyaEkle.Text = "Dosya Ekle";
            this.buttonDosyaEkle.UseVisualStyleBackColor = true;
            this.buttonDosyaEkle.Click += new System.EventHandler(this.buttonDosyaEkle_Click);
            // 
            // labelDosyaAdi
            // 
            this.labelDosyaAdi.AutoSize = true;
            this.labelDosyaAdi.Location = new System.Drawing.Point(110, 575);
            this.labelDosyaAdi.Name = "labelDosyaAdi";
            this.labelDosyaAdi.Size = new System.Drawing.Size(0, 13);
            this.labelDosyaAdi.TabIndex = 19;
            // 
            // dataGridViewCozumEkle
            // 
            this.dataGridViewCozumEkle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCozumEkle.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCozumEkle.Name = "dataGridViewCozumEkle";
            this.dataGridViewCozumEkle.Size = new System.Drawing.Size(560, 244);
            this.dataGridViewCozumEkle.TabIndex = 1;
            this.dataGridViewCozumEkle.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCozumEkle_CellMouseDoubleClick);
            // 
            // tabPageHatalar
            // 
            this.tabPageHatalar.Controls.Add(this.button2);
            this.tabPageHatalar.Controls.Add(this.label24);
            this.tabPageHatalar.Controls.Add(this.comboBoxTumHatalarKategori);
            this.tabPageHatalar.Controls.Add(this.dataGridViewTumHatalar);
            this.tabPageHatalar.Location = new System.Drawing.Point(4, 22);
            this.tabPageHatalar.Name = "tabPageHatalar";
            this.tabPageHatalar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHatalar.Size = new System.Drawing.Size(566, 509);
            this.tabPageHatalar.TabIndex = 3;
            this.tabPageHatalar.Text = "Tüm Hatalar";
            this.tabPageHatalar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pdf çıktısı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(47, 456);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Kategori";
            // 
            // comboBoxTumHatalarKategori
            // 
            this.comboBoxTumHatalarKategori.FormattingEnabled = true;
            this.comboBoxTumHatalarKategori.Location = new System.Drawing.Point(99, 453);
            this.comboBoxTumHatalarKategori.Name = "comboBoxTumHatalarKategori";
            this.comboBoxTumHatalarKategori.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTumHatalarKategori.TabIndex = 1;
            this.comboBoxTumHatalarKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxTumHatalarKategori_SelectedIndexChanged);
            // 
            // dataGridViewTumHatalar
            // 
            this.dataGridViewTumHatalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTumHatalar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTumHatalar.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTumHatalar.Name = "dataGridViewTumHatalar";
            this.dataGridViewTumHatalar.ReadOnly = true;
            this.dataGridViewTumHatalar.Size = new System.Drawing.Size(566, 447);
            this.dataGridViewTumHatalar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Sanlab Arıza Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxCozum.ResumeLayout(false);
            this.groupBoxCozum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanlabHataTespitVTDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageHata.ResumeLayout(false);
            this.tabPageHata.PerformLayout();
            this.tabPageCozum.ResumeLayout(false);
            this.tabPageKisi.ResumeLayout(false);
            this.tabPageKisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageCozumEkle.ResumeLayout(false);
            this.tabPageCozumEkle.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCozumEkle)).EndInit();
            this.tabPageHatalar.ResumeLayout(false);
            this.tabPageHatalar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumHatalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCozum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBoxCozum;
        private System.Windows.Forms.GroupBox groupBox1;
        private SanlabHataTespitVTDataSet sanlabHataTespitVTDataSet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHata;
        private System.Windows.Forms.TabPage tabPageCozum;
        private System.Windows.Forms.ComboBox comboBoxGonderenKisiler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPageKisi;
        private System.Windows.Forms.Button buttonKisiEkle;
        private System.Windows.Forms.TextBox textBoxTelNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMailGonder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPageHatalar;
        private System.Windows.Forms.DataGridView dataGridViewTumHatalar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonKategoriEkle;
        private System.Windows.Forms.TextBox textBoxHataTanim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxKisiArama;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonKisiSil;
        private System.Windows.Forms.Button buttonKisiGuncelle;
        private System.Windows.Forms.TextBox textBoxCozumHataTanım;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPageCozumEkle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonCozumResimEkle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxCozumAciklama;
        private System.Windows.Forms.Button buttonCozumGonder;
        private System.Windows.Forms.DataGridView dataGridViewCozumEkle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxCozumTanım;
        private System.Windows.Forms.Button buttonMusteriEkle;
        private System.Windows.Forms.ComboBox comboBoxMusteri;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelDosyaAdi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonDosyaEkle;
        private System.Windows.Forms.Button buttonDosyaIndir;
        private System.Windows.Forms.Label labelCozumDosyaAdi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxHataAciklama;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxCozumHataAra;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboBoxTumHatalarKategori;
    }
}

