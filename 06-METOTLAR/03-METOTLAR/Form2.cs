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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);

            int sonuc=Topla(sayi1, sayi2);
            label1.Text = sonuc.ToString();

        }

        private int Topla(int x, int y)
        {
            if (x>y)
                return x-y;
            else
                return y-x;
        
        }
    }
}
