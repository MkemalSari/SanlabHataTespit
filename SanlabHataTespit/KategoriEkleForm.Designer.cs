namespace SanlabHataTespit
{
    partial class KategoriEkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxKategoriEkle = new System.Windows.Forms.TextBox();
            this.buttonKategoriEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKategoriEkle
            // 
            this.textBoxKategoriEkle.Location = new System.Drawing.Point(83, 30);
            this.textBoxKategoriEkle.Name = "textBoxKategoriEkle";
            this.textBoxKategoriEkle.Size = new System.Drawing.Size(100, 20);
            this.textBoxKategoriEkle.TabIndex = 0;
            // 
            // buttonKategoriEkle
            // 
            this.buttonKategoriEkle.Location = new System.Drawing.Point(108, 66);
            this.buttonKategoriEkle.Name = "buttonKategoriEkle";
            this.buttonKategoriEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonKategoriEkle.TabIndex = 1;
            this.buttonKategoriEkle.Text = "Ekle";
            this.buttonKategoriEkle.UseVisualStyleBackColor = true;
            this.buttonKategoriEkle.Click += new System.EventHandler(this.buttonKategoriEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adı";
            // 
            // KategoriEkleForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 152);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKategoriEkle);
            this.Controls.Add(this.textBoxKategoriEkle);
            this.Name = "KategoriEkleForm";
            this.Text = "Kategori Ekle";
            this.Load += new System.EventHandler(this.FormResim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKategoriEkle;
        private System.Windows.Forms.Button buttonKategoriEkle;
        private System.Windows.Forms.Label label1;
    }
}