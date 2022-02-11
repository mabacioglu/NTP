namespace _KitapDukkani
{
    partial class Form1
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
            this.btnMusterileriGetir = new System.Windows.Forms.Button();
            this.lsbMusteriler = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMusteriYas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.txtMeslegi = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.cmbKitapTuru = new System.Windows.Forms.ComboBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.chkNobel = new System.Windows.Forms.CheckBox();
            this.dtYazarDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMusterileriGetir
            // 
            this.btnMusterileriGetir.Location = new System.Drawing.Point(341, 441);
            this.btnMusterileriGetir.Name = "btnMusterileriGetir";
            this.btnMusterileriGetir.Size = new System.Drawing.Size(141, 23);
            this.btnMusterileriGetir.TabIndex = 9;
            this.btnMusterileriGetir.Text = "Verileri Getir";
            this.btnMusterileriGetir.UseVisualStyleBackColor = true;
            this.btnMusterileriGetir.Click += new System.EventHandler(this.btnMusterileriGetir_Click);
            // 
            // lsbMusteriler
            // 
            this.lsbMusteriler.FormattingEnabled = true;
            this.lsbMusteriler.Location = new System.Drawing.Point(341, 249);
            this.lsbMusteriler.Name = "lsbMusteriler";
            this.lsbMusteriler.Size = new System.Drawing.Size(255, 186);
            this.lsbMusteriler.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMusteriYas);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnMusteriEkle);
            this.groupBox3.Controls.Add(this.cmbKitap);
            this.groupBox3.Controls.Add(this.txtMeslegi);
            this.groupBox3.Controls.Add(this.txtMusteriAdi);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(32, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 219);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MÜŞTERİ EKLE";
            // 
            // txtMusteriYas
            // 
            this.txtMusteriYas.Location = new System.Drawing.Point(110, 117);
            this.txtMusteriYas.Name = "txtMusteriYas";
            this.txtMusteriYas.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriYas.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "YAŞ";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(102, 159);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(108, 23);
            this.btnMusteriEkle.TabIndex = 6;
            this.btnMusteriEkle.Text = "MÜŞTERİ EKLE";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // cmbKitap
            // 
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Location = new System.Drawing.Point(110, 87);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(100, 21);
            this.cmbKitap.TabIndex = 5;
            // 
            // txtMeslegi
            // 
            this.txtMeslegi.Location = new System.Drawing.Point(110, 62);
            this.txtMeslegi.Name = "txtMeslegi";
            this.txtMeslegi.Size = new System.Drawing.Size(100, 20);
            this.txtMeslegi.TabIndex = 4;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(110, 37);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAdi.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "KİTAP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "MESLEĞİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "MÜŞTERİ ADI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Controls.Add(this.cmbYazar);
            this.groupBox2.Controls.Add(this.txtFiyat);
            this.groupBox2.Controls.Add(this.txtSayfaSayisi);
            this.groupBox2.Controls.Add(this.cmbKitapTuru);
            this.groupBox2.Controls.Add(this.txtKitapAdi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(341, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 207);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KİTAP EKLE";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(134, 165);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(100, 23);
            this.btnKitapEkle.TabIndex = 10;
            this.btnKitapEkle.Text = "KİTAP EKLE";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // cmbYazar
            // 
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(89, 132);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(145, 21);
            this.cmbYazar.TabIndex = 9;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(89, 109);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(145, 20);
            this.txtFiyat.TabIndex = 8;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(89, 86);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(145, 20);
            this.txtSayfaSayisi.TabIndex = 7;
            // 
            // cmbKitapTuru
            // 
            this.cmbKitapTuru.FormattingEnabled = true;
            this.cmbKitapTuru.Items.AddRange(new object[] {
            "ROMAN",
            "HİKAYE"});
            this.cmbKitapTuru.Location = new System.Drawing.Point(89, 62);
            this.cmbKitapTuru.Name = "cmbKitapTuru";
            this.cmbKitapTuru.Size = new System.Drawing.Size(145, 21);
            this.cmbKitapTuru.TabIndex = 6;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(89, 37);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(145, 20);
            this.txtKitapAdi.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "YAZAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "FİYAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "SAYFA SAYISI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "KİTAP TURU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "KİTAP ADI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYazarEkle);
            this.groupBox1.Controls.Add(this.chkNobel);
            this.groupBox1.Controls.Add(this.dtYazarDogumTarihi);
            this.groupBox1.Controls.Add(this.txtYazarAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YAZAR EKLE";
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Location = new System.Drawing.Point(143, 141);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(134, 23);
            this.btnYazarEkle.TabIndex = 6;
            this.btnYazarEkle.Text = "YAZAR EKLE";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // chkNobel
            // 
            this.chkNobel.AutoSize = true;
            this.chkNobel.Location = new System.Drawing.Point(143, 92);
            this.chkNobel.Name = "chkNobel";
            this.chkNobel.Size = new System.Drawing.Size(48, 17);
            this.chkNobel.TabIndex = 5;
            this.chkNobel.Text = "VAR";
            this.chkNobel.UseVisualStyleBackColor = true;
            // 
            // dtYazarDogumTarihi
            // 
            this.dtYazarDogumTarihi.Location = new System.Drawing.Point(143, 66);
            this.dtYazarDogumTarihi.Name = "dtYazarDogumTarihi";
            this.dtYazarDogumTarihi.Size = new System.Drawing.Size(135, 20);
            this.dtYazarDogumTarihi.TabIndex = 4;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(143, 40);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(135, 20);
            this.txtYazarAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOBEL ÖDÜLÜ VAR MI?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOĞUM TARİHİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 485);
            this.Controls.Add(this.btnMusterileriGetir);
            this.Controls.Add(this.lsbMusteriler);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "KİTAP DÜKKANI";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusterileriGetir;
        private System.Windows.Forms.ListBox lsbMusteriler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMusteriYas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.TextBox txtMeslegi;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.ComboBox cmbKitapTuru;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.CheckBox chkNobel;
        private System.Windows.Forms.DateTimePicker dtYazarDogumTarihi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

