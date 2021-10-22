namespace _03_ELSE_IF_KULLANIMI
{
    partial class UrunIndirim
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
            this.txtGirilenFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunFiyatı = new System.Windows.Forms.TextBox();
            this.txtIndirimOranı = new System.Windows.Forms.TextBox();
            this.txtIndirimliFiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGirilenFiyat
            // 
            this.txtGirilenFiyat.Location = new System.Drawing.Point(201, 38);
            this.txtGirilenFiyat.Name = "txtGirilenFiyat";
            this.txtGirilenFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtGirilenFiyat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Fiyatını Giriniz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "İndirim Oranı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "İndirimli Fiyatı";
            // 
            // txtUrunFiyatı
            // 
            this.txtUrunFiyatı.Enabled = false;
            this.txtUrunFiyatı.Location = new System.Drawing.Point(160, 142);
            this.txtUrunFiyatı.Name = "txtUrunFiyatı";
            this.txtUrunFiyatı.Size = new System.Drawing.Size(100, 20);
            this.txtUrunFiyatı.TabIndex = 4;
            // 
            // txtIndirimOranı
            // 
            this.txtIndirimOranı.Enabled = false;
            this.txtIndirimOranı.Location = new System.Drawing.Point(160, 168);
            this.txtIndirimOranı.Name = "txtIndirimOranı";
            this.txtIndirimOranı.Size = new System.Drawing.Size(100, 20);
            this.txtIndirimOranı.TabIndex = 4;
            // 
            // txtIndirimliFiyat
            // 
            this.txtIndirimliFiyat.Enabled = false;
            this.txtIndirimliFiyat.Location = new System.Drawing.Point(160, 193);
            this.txtIndirimliFiyat.Name = "txtIndirimliFiyat";
            this.txtIndirimliFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtIndirimliFiyat.TabIndex = 4;
            // 
            // UrunIndirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 263);
            this.Controls.Add(this.txtIndirimliFiyat);
            this.Controls.Add(this.txtIndirimOranı);
            this.Controls.Add(this.txtUrunFiyatı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGirilenFiyat);
            this.Name = "UrunIndirim";
            this.Text = "UrunIndirim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGirilenFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunFiyatı;
        private System.Windows.Forms.TextBox txtIndirimOranı;
        private System.Windows.Forms.TextBox txtIndirimliFiyat;
    }
}