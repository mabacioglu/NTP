namespace Operatorler_Ornek
{
    partial class SayiOrnek
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
            this.lblSayi = new System.Windows.Forms.Label();
            this.btnArtir = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.txtArtisMiktari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi.Location = new System.Drawing.Point(131, 66);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(27, 29);
            this.lblSayi.TabIndex = 0;
            this.lblSayi.Text = "0";
            // 
            // btnArtir
            // 
            this.btnArtir.Location = new System.Drawing.Point(79, 137);
            this.btnArtir.Name = "btnArtir";
            this.btnArtir.Size = new System.Drawing.Size(53, 44);
            this.btnArtir.TabIndex = 1;
            this.btnArtir.Text = "+";
            this.btnArtir.UseVisualStyleBackColor = true;
            this.btnArtir.Click += new System.EventHandler(this.btnArtir_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(157, 137);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(53, 44);
            this.btnAzalt.TabIndex = 1;
            this.btnAzalt.Text = "-";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // txtArtisMiktari
            // 
            this.txtArtisMiktari.Location = new System.Drawing.Point(99, 210);
            this.txtArtisMiktari.Name = "txtArtisMiktari";
            this.txtArtisMiktari.Size = new System.Drawing.Size(100, 20);
            this.txtArtisMiktari.TabIndex = 2;
            this.txtArtisMiktari.Text = "1";
            // 
            // SayiOrnek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtArtisMiktari);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnArtir);
            this.Controls.Add(this.lblSayi);
            this.Name = "SayiOrnek";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Button btnArtir;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.TextBox txtArtisMiktari;
    }
}