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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            int a,sayac=0,toplam=0;
            
            while (true)
            {
                a = rnd.Next(1, 101);
                listBox1.Items.Add(a);
                sayac++;
                toplam += a;
                if (a > 95)
                    break;
            }
            txtSayisi.Text = sayac.ToString();
            txtToplami.Text = toplam.ToString();
            int ortalama = toplam / sayac;
            txtOrtalamasi.Text = ortalama.ToString();
        }
    }
}
