using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_LIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> sehirler = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            sehirler.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }
    }
}
