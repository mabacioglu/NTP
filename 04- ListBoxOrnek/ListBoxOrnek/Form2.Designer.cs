namespace ListBoxOrnek
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnEkle1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEkle2 = new System.Windows.Forms.Button();
            this.btnSagaGecir = new System.Windows.Forms.Button();
            this.btnSolaGecir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(61, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(303, 130);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 2;
            // 
            // btnEkle1
            // 
            this.btnEkle1.Location = new System.Drawing.Point(83, 91);
            this.btnEkle1.Name = "btnEkle1";
            this.btnEkle1.Size = new System.Drawing.Size(75, 23);
            this.btnEkle1.TabIndex = 3;
            this.btnEkle1.Text = "EKLE";
            this.btnEkle1.UseVisualStyleBackColor = true;
            this.btnEkle1.Click += new System.EventHandler(this.btnEkle1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnEkle2
            // 
            this.btnEkle2.Location = new System.Drawing.Point(319, 91);
            this.btnEkle2.Name = "btnEkle2";
            this.btnEkle2.Size = new System.Drawing.Size(75, 23);
            this.btnEkle2.TabIndex = 3;
            this.btnEkle2.Text = "EKLE";
            this.btnEkle2.UseVisualStyleBackColor = true;
            this.btnEkle2.Click += new System.EventHandler(this.btnEkle2_Click);
            // 
            // btnSagaGecir
            // 
            this.btnSagaGecir.Location = new System.Drawing.Point(209, 145);
            this.btnSagaGecir.Name = "btnSagaGecir";
            this.btnSagaGecir.Size = new System.Drawing.Size(75, 23);
            this.btnSagaGecir.TabIndex = 3;
            this.btnSagaGecir.Text = ">>";
            this.btnSagaGecir.UseVisualStyleBackColor = true;
            this.btnSagaGecir.Click += new System.EventHandler(this.btnSagaGecir_Click);
            // 
            // btnSolaGecir
            // 
            this.btnSolaGecir.Location = new System.Drawing.Point(209, 174);
            this.btnSolaGecir.Name = "btnSolaGecir";
            this.btnSolaGecir.Size = new System.Drawing.Size(75, 23);
            this.btnSolaGecir.TabIndex = 3;
            this.btnSolaGecir.Text = "<<";
            this.btnSolaGecir.UseVisualStyleBackColor = true;
            this.btnSolaGecir.Click += new System.EventHandler(this.btnSolaGecir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 282);
            this.Controls.Add(this.btnSolaGecir);
            this.Controls.Add(this.btnSagaGecir);
            this.Controls.Add(this.btnEkle2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEkle1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnEkle1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEkle2;
        private System.Windows.Forms.Button btnSagaGecir;
        private System.Windows.Forms.Button btnSolaGecir;
    }
}