using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_DONGULER
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            int toplam = 0;
            int carpim = 1;
            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;
                carpim *= i;
            }
            lblToplam.Text = toplam.ToString();
            lblCarpim.Text = carpim.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }
    }
}
