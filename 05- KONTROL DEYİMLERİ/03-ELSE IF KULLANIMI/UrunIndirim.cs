using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_ELSE_IF_KULLANIMI
{
    public partial class UrunIndirim : Form
    {
        public UrunIndirim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat, indirimliFiyat;
            fiyat = double.Parse(txtGirilenFiyat.Text);
            txtUrunFiyatı.Text = fiyat.ToString();

            if (fiyat<100)
            { 
                txtIndirimOranı.Text = "0";
                txtIndirimliFiyat.Text = fiyat.ToString();
            }
            else if (fiyat<200)
            {
                txtIndirimOranı.Text = "10";
                indirimliFiyat = fiyat-(fiyat * 0.10);
                txtIndirimliFiyat.Text = indirimliFiyat.ToString();
            }
            else if (fiyat<300)
            {
                txtIndirimOranı.Text = "15";
                indirimliFiyat = fiyat - (fiyat * 0.15);
                txtIndirimliFiyat.Text = indirimliFiyat.ToString();
            }
            else
            {
                txtIndirimOranı.Text = "20";
                indirimliFiyat = fiyat - (fiyat * 0.20);
                txtIndirimliFiyat.Text = indirimliFiyat.ToString();
            }
        }
    }
}
