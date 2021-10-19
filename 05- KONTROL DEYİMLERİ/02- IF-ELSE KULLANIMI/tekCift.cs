using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02__IF_ELSE_KULLANIMI
{
    public partial class tekCift : Form
    {
        public tekCift()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(txtSayi.Text);
            if (  sayi % 2 == 0    )
            {
                MessageBox.Show("Sayi ÇİFTTİR");
            }
            else
            {
                MessageBox.Show("Sayi TEKTİR");

            }
        }

        private void tekCift_Load(object sender, EventArgs e)
        {

        }
    }
}
