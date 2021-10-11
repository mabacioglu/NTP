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
    public partial class Form2 : Form
    {
        public Form2()
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
            catch(Exception exc)  // hata olduğu durumda çalışacak yer
            {
                MessageBox.Show(exc.Message,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
            finally // iki bloktan hangisi çalışırsa çalışsın bu blok sonrasında çalışır
            {
                txtSayi1.Text = "";
                txtSayi2.Text = null;
            }
        }
    }
}
