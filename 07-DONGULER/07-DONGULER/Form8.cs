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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        int puan1 = 0, puan2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            int sayi,sayi1, sayi2;
            sayi1 = int.Parse(txtOyuncu1.Text);
            sayi2 = int.Parse(txtOyuncu2.Text);
            while (true)
            {
                sayi = rnd.Next(1, 51);
                listBox1.Items.Add(sayi);
                if (sayi1 == sayi)
                {
                    MessageBox.Show("1.oyuncu");
                    puan1++;
                    lblOyuncu1.Text = puan1.ToString();
                    break;
                }
                if (sayi2 == sayi)
                {
                    MessageBox.Show("2.oyuncu");
                    puan2++;
                    lblOyuncu2.Text = puan2.ToString();
                    break; 
                }
            }
            if (puan2 == 5 || puan1 == 5)
            {
                string kazanan;
                if (puan1 == 5)
                    kazanan = "Oyuncu 1";
                else
                    kazanan = "Oyuncu 2";
                MessageBox.Show("Oyunu "+kazanan+ " kazanmıştır");
                Application.Exit();
            }
        }
    }
}
