using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_IC_ICE_IF_KULLANIMI_NESTED_IF
{
    public partial class AskerlikCagi : Form
    {
        public AskerlikCagi()
        {
            InitializeComponent();
        }

        private void AskerlikCagi_Load(object sender, EventArgs e)
        {
            for (int i = 15; i <= 85; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbKadin.Checked==true)
            {
                MessageBox.Show("Kadınlar askere gitmezler...");
            }
            else
            {
                int yas=int.Parse(comboBox1.Text);
                if (yas<20)
                {
                    MessageBox.Show("Askerlik Çağına girmediniz...");
                }
                else if (yas>40)
                {
                    MessageBox.Show("Askerlik Çağından çıktınız..");
                }
                else
                {
                    MessageBox.Show("Askerlik Çağı içerisindesiniz..");
                }
            }


        }
    }
}
