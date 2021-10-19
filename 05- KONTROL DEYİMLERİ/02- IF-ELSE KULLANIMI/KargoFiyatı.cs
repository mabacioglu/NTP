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
    public partial class KargoFiyatı : Form
    {
        public KargoFiyatı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int urunFiyati, urunAdedi, toplamFiyat;
            urunFiyati = int.Parse(txtUrunFiyati.Text);
            urunAdedi = int.Parse(txtUrunAdedi.Text);
            toplamFiyat = urunAdedi * urunFiyati;

            if (toplamFiyat<100)
            {
                toplamFiyat += 10;
                lblFiyat.Text = toplamFiyat.ToString();
            }
            else
            {
                lblFiyat.Text = toplamFiyat.ToString();
            }
        }
    }
}
