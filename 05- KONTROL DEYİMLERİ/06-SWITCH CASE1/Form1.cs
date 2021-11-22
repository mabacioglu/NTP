using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_SWITCH_CASE1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc=0;
            string islem;
            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);
            islem = comboBox1.Text;
            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                case "%":
                    sonuc = sayi1 % sayi2;
                    break;
              }
            txtSonuc.Text = sonuc.ToString();
        }
    }
}
