namespace _07_DONGULER
{
    partial class Form6
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSayisi = new System.Windows.Forms.TextBox();
            this.txtToplami = new System.Windows.Forms.TextBox();
            this.txtOrtalamasi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(107, 329);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 99);
            this.button1.TabIndex = 1;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eleman Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ESayıların Toplamı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sayıların Ortalaması";
            // 
            // txtSayisi
            // 
            this.txtSayisi.Enabled = false;
            this.txtSayisi.Location = new System.Drawing.Point(264, 204);
            this.txtSayisi.Name = "txtSayisi";
            this.txtSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSayisi.TabIndex = 3;
            // 
            // txtToplami
            // 
            this.txtToplami.Enabled = false;
            this.txtToplami.Location = new System.Drawing.Point(264, 233);
            this.txtToplami.Name = "txtToplami";
            this.txtToplami.Size = new System.Drawing.Size(100, 20);
            this.txtToplami.TabIndex = 3;
            // 
            // txtOrtalamasi
            // 
            this.txtOrtalamasi.Enabled = false;
            this.txtOrtalamasi.Location = new System.Drawing.Point(264, 264);
            this.txtOrtalamasi.Name = "txtOrtalamasi";
            this.txtOrtalamasi.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalamasi.TabIndex = 3;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 399);
            this.Controls.Add(this.txtOrtalamasi);
            this.Controls.Add(this.txtToplami);
            this.Controls.Add(this.txtSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSayisi;
        private System.Windows.Forms.TextBox txtToplami;
        private System.Windows.Forms.TextBox txtOrtalamasi;
    }
}