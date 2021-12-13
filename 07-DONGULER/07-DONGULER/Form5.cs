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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 10;
            int toplam = 0;
            while (x<=10)
            {
                listBox1.Items.Add(x); 
                listBox2.Items.Add(y);
                toplam += x;
                x++;
                y--;
                
            }
            lblToplam.Text = toplam.ToString();
            

        }
    }
}
