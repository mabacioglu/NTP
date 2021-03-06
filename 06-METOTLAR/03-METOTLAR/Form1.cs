using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_METOTLAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // MEHMET ABACIOĞLU- PARAMETRE ALAN DEĞER DÖNDERMEYEN -1 
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);

            if (sayi1 > sayi2)
            {
                Dikdortgen(sayi1, sayi2);
            }
            else if (sayi1 < sayi2)
            {
                Ucgen(sayi1, sayi2);
            }
            else
            {
                Kare(sayi1);
            }
                
         }

        private static void Kare(int sayi1)
        {
            int alan = sayi1 * sayi1;
            int cevre = 4 * sayi1;
            MessageBox.Show("Karenin Alanı= " + alan.ToString() + "  Çevresi= " + cevre.ToString());
        }

        private static void Ucgen(int sayi1, int sayi2)
        {
            int alan = (sayi1 * sayi2) / 2;
            MessageBox.Show("Üçgenin Alanı= " + alan.ToString());
        }

        private static void Dikdortgen(int sayi1, int sayi2)
        {
            int alan = sayi1 * sayi2;
            int cevre = 2 * (sayi1 + sayi2);
            MessageBox.Show("Dikdörtgenin Alanı= " + alan.ToString() + "  Çevresi= " + cevre.ToString());
        }

        
        


    }
}
