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
    public partial class kullaniciAdiSifre : Form
    {
        public kullaniciAdiSifre()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            if (koşul)
            {
              koşul doğruysa çalıştırılacak kodlar  
            }

            else
            {
                koşul doğru değilse çalıştırılacak kodlar
            }
             */




        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre;
            kullaniciAdi = txtKullaniciAdi.Text;
            sifre = txtSifre.Text;
            if (kullaniciAdi=="admin"  &&  sifre=="12345")
            {
                MessageBox.Show("Giriş Başarılı...");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
