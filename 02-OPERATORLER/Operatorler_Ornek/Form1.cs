using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operatorler_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2,sonuc;
            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);
            sonuc = sayi1 + sayi2;
            txtSonuc.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = (int.Parse(txtSayi1.Text) - int.Parse(txtSayi2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = double.Parse(txtSayi1.Text);
            sayi2 = double.Parse(txtSayi2.Text);
            sonuc = sayi1 * sayi2;
            txtSonuc.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = double.Parse(txtSayi1.Text);
            sayi2 = double.Parse(txtSayi2.Text);
            sonuc = sayi1 / sayi2;
            txtSonuc.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);
            sonuc = sayi1 % sayi2;
            txtSonuc.Text = sonuc.ToString();
        }
    }
}
