namespace SanlabHataTespit
{
    partial class MusteriEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMusteriEkle = new System.Windows.Forms.Button();
            this.textBoxMusteriAd = new System.Windows.Forms.TextBox();
            this.textBoxMusteriAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMusteriTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMusteriMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Müşteri Adı";
            // 
            // buttonMusteriEkle
            // 
            this.buttonMusteriEkle.Location = new System.Drawing.Point(129, 139);
            this.buttonMusteriEkle.Name = "buttonMusteriEkle";
            this.buttonMusteriEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonMusteriEkle.TabIndex = 4;
            this.buttonMusteriEkle.Text = "Ekle";
            this.buttonMusteriEkle.UseVisualStyleBackColor = true;
            this.buttonMusteriEkle.Click += new System.EventHandler(this.buttonMusteriEkle_Click);
            // 
            // textBoxMusteriAd
            // 
            this.textBoxMusteriAd.Location = new System.Drawing.Point(104, 23);
            this.textBoxMusteriAd.Name = "textBoxMusteriAd";
            this.textBoxMusteriAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxMusteriAd.TabIndex = 3;
            // 
            // textBoxMusteriAdress
            // 
            this.textBoxMusteriAdress.Location = new System.Drawing.Point(104, 49);
            this.textBoxMusteriAdress.Name = "textBoxMusteriAdress";
            this.textBoxMusteriAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxMusteriAdress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Müşteri Adres";
            // 
            // textBoxMusteriTelefon
            // 
            this.textBoxMusteriTelefon.Location = new System.Drawing.Point(104, 75);
            this.textBoxMusteriTelefon.Name = "textBoxMusteriTelefon";
            this.textBoxMusteriTelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxMusteriTelefon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Müşteri Telefon";
            // 
            // textBoxMusteriMail
            // 
            this.textBoxMusteriMail.Location = new System.Drawing.Point(104, 101);
            this.textBoxMusteriMail.Name = "textBoxMusteriMail";
            this.textBoxMusteriMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxMusteriMail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Müşteri Mail";
            // 
            // MusteriEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 199);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMusteriEkle);
            this.Controls.Add(this.textBoxMusteriMail);
            this.Controls.Add(this.textBoxMusteriTelefon);
            this.Controls.Add(this.textBoxMusteriAdress);
            this.Controls.Add(this.textBoxMusteriAd);
            this.Name = "MusteriEkleForm";
            this.Text = "MusteriEkleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMusteriEkle;
        private System.Windows.Forms.TextBox textBoxMusteriAd;
        private System.Windows.Forms.TextBox textBoxMusteriAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMusteriTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMusteriMail;
        private System.Windows.Forms.Label label4;
    }
}