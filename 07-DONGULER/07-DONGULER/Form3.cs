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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi = int.Parse(txtSayi.Text);
            Random rnd = new Random();
            for (int i = 0; i < sayi; i++)
            {
                listBox1.Items.Add(rnd.Next(1,100));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int a = (int)listBox1.Items[i];
                if (a % 2 == 1)
                {
                    lstTek.Items.Add(a);
                }
                else 
                {
                    lstCift.Items.Add(a);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Close();
        }

        
    }
}
