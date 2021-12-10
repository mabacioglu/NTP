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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 10; i++) 
            //{
            //    MessageBox.Show(i.ToString());
            //}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bas, bit, art;
            bas = int.Parse(txtBaslangic.Text);
            bit = int.Parse(txtBitis.Text);
            art = int.Parse(txtArtis.Text);
            if (bas < bit)
            { 
                 for (int i = bas; i <= bit; i+=art)
                {
                    listBox1.Items.Add(i.ToString());
                }
            
            }

            if (bas > bit)
            { 
                for (int i=bit;i<=bas;i+=art)
                    listBox1.Items.Add(i.ToString());
            }
           
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

    }
}
