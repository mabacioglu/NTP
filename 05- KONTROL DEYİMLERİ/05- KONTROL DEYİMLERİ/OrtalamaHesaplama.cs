using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05__KONTROL_DEYİMLERİ
{
    public partial class OrtalamaHesaplama : Form
    {
        public OrtalamaHesaplama()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int not1, not2, performans, ortalama;
            not1 = int.Parse(txtNot1.Text);
            not2 = int.Parse(txtNot2.Text);
            performans = int.Parse(txtPerformans.Text);
            ortalama = (not1 + not2 + performans) / 3;
            lblOrtalama.Text = ortalama.ToString();
            if (ortalama >= 50)
                lblSonuc.Text = "GEÇTİ";
            if (ortalama < 50)
                lblSonuc.Text = "KALDI";
        }

        private void txtNot1_TextChanged(object sender, EventArgs e)
        {
            int not1 = int.Parse(txtNot1.Text);
            if (not1 < 0 || not1 > 100)
            {
                MessageBox.Show("Hatalı giriş lütfen 0-100 arası bir sayı giriniz");
                txtNot1.Text = "";
            }

        }

        private void txtNot2_TextChanged(object sender, EventArgs e)
        {
            int not2 = int.Parse(txtNot2.Text);
            if (not2 < 0 || not2 > 100)
            {
                MessageBox.Show("Hatalı giriş lütfen 0-100 arası bir sayı giriniz");
                txtNot2.Text = "";
            }
        }

        private void txtPerformans_TextChanged(object sender, EventArgs e)
        {
            int performans = int.Parse(txtPerformans.Text);
            if (performans < 0 || performans > 100)
            {
                MessageBox.Show("Hatalı giriş lütfen 0-100 arası bir sayı giriniz");
               txtPerformans.Text = "";
            }
        }


    }
}
