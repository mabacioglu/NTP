using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunTimeHatalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try  // çalışmasını istediğimiz kodların yazıldığı yer
            {
                int sayi1, sayi2;
                double sonuc;
                sayi1 = int.Parse(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
                sonuc = sayi1 / sayi2;
                lblSonuc.Text = sonuc.ToString();
            }
            catch  // hata olduğu durumda çalışacak yer
            {
                lblSonuc.Text = "Hatalı bilgi girişi";
            }
            finally // iki bloktan hangisi çalışırsa çalışsın bu blok sonrasında çalışır
            {
                txtSayi1.Text = "";
                txtSayi2.Text = null;
            }


           
        }
    }
}
