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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            Random rst = new Random();
            sayi = rst.Next(1, 15);
            switch (sayi)
            {
                case 1:
                    listBox1.Items.Add("BİR");
                    break;
                case 2:
                    listBox1.Items.Add("İKİ");
                    break;
                case 3:
                    listBox1.Items.Add("ÜÇ");
                    break;
                case 4:
                    listBox1.Items.Add("DÖRT");
                    break;
                case 5:
                    listBox1.Items.Add("BEŞ");
                    break;
                case 6:
                    listBox1.Items.Add("ALTI");
                    break;
                case 7:
                    listBox1.Items.Add("YEDİ");
                    break;
                case 8:
                    listBox1.Items.Add("SEKİZ");
                    break;
                case 9:
                    listBox1.Items.Add("DOKUZ");
                    break;
                default:
                    listBox1.Items.Add("DOKUZDAN BÜYÜK");
                    break;

            }
        }
    }
}
