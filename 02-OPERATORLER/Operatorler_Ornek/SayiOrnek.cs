using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operatorler_Ornek
{
    public partial class SayiOrnek : Form
    {
        public SayiOrnek()
        {
            InitializeComponent();
        }

        private void btnArtir_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblSayi.Text);
            sayi += int.Parse(txtArtisMiktari.Text);
            lblSayi.Text = sayi.ToString();
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblSayi.Text);
            sayi -= int.Parse(txtArtisMiktari.Text);
            lblSayi.Text = sayi.ToString();
        }
    }
}
