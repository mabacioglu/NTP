namespace _02_ParametreKullanımı
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
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtKardesSayisi = new System.Windows.Forms.TextBox();
            this.txtNotOrtalamasi = new System.Windows.Forms.TextBox();
            this.txtAylikGeliri = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbEgitimDurumu = new System.Windows.Forms.ComboBox();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.chkDahaOnceBasvuruYaptiMi = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(114, 45);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 0;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(114, 78);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadi.TabIndex = 0;
            // 
            // txtKardesSayisi
            // 
            this.txtKardesSayisi.Location = new System.Drawing.Point(114, 144);
            this.txtKardesSayisi.Name = "txtKardesSayisi";
            this.txtKardesSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKardesSayisi.TabIndex = 0;
            // 
            // txtNotOrtalamasi
            // 
            this.txtNotOrtalamasi.Location = new System.Drawing.Point(529, 46);
            this.txtNotOrtalamasi.Name = "txtNotOrtalamasi";
            this.txtNotOrtalamasi.Size = new System.Drawing.Size(100, 20);
            this.txtNotOrtalamasi.TabIndex = 0;
            // 
            // txtAylikGeliri
            // 
            this.txtAylikGeliri.Location = new System.Drawing.Point(529, 88);
            this.txtAylikGeliri.Name = "txtAylikGeliri";
            this.txtAylikGeliri.Size = new System.Drawing.Size(100, 20);
            this.txtAylikGeliri.TabIndex = 0;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(114, 110);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.dtpDogumTarihi.TabIndex = 1;
            // 
            // cmbEgitimDurumu
            // 
            this.cmbEgitimDurumu.FormattingEnabled = true;
            this.cmbEgitimDurumu.Items.AddRange(new object[] {
            "İLKOKUL",
            "ORTAOKUL",
            "LİSE",
            "LİSANS",
            "YÜKSEK LİSANS"});
            this.cmbEgitimDurumu.Location = new System.Drawing.Point(529, 130);
            this.cmbEgitimDurumu.Name = "cmbEgitimDurumu";
            this.cmbEgitimDurumu.Size = new System.Drawing.Size(121, 21);
            this.cmbEgitimDurumu.TabIndex = 2;
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Location = new System.Drawing.Point(114, 182);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(52, 17);
            this.rdbKadin.TabIndex = 3;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(172, 182);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbErkek.TabIndex = 4;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // chkDahaOnceBasvuruYaptiMi
            // 
            this.chkDahaOnceBasvuruYaptiMi.AutoSize = true;
            this.chkDahaOnceBasvuruYaptiMi.Location = new System.Drawing.Point(529, 173);
            this.chkDahaOnceBasvuruYaptiMi.Name = "chkDahaOnceBasvuruYaptiMi";
            this.chkDahaOnceBasvuruYaptiMi.Size = new System.Drawing.Size(15, 14);
            this.chkDahaOnceBasvuruYaptiMi.TabIndex = 5;
            this.chkDahaOnceBasvuruYaptiMi.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(429, 226);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 62);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 175);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kardeş Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Daha Önce Başvuru Yaptı Mı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Eğitim Durumu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Aylık Geliri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Not Ortalaması";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cinsiyet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 525);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkDahaOnceBasvuruYaptiMi);
            this.Controls.Add(this.rdbErkek);
            this.Controls.Add(this.rdbKadin);
            this.Controls.Add(this.cmbEgitimDurumu);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtAylikGeliri);
            this.Controls.Add(this.txtNotOrtalamasi);
            this.Controls.Add(this.txtKardesSayisi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtKardesSayisi;
        private System.Windows.Forms.TextBox txtNotOrtalamasi;
        private System.Windows.Forms.TextBox txtAylikGeliri;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ComboBox cmbEgitimDurumu;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.CheckBox chkDahaOnceBasvuruYaptiMi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

