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
    public partial class KullaniciAdiParola : Form
    {
        public KullaniciAdiParola()
        {
            InitializeComponent();
        }
     
       


                private void Form1_Load(object sender, EventArgs e)
        {

        }

                private void button1_Click(object sender, EventArgs e)
                {
                    string kAdi, parola;
                    kAdi = txtKullaniciAdi.Text;
                    parola = txtParola.Text;
                    if (kAdi=="admin")
                    {
                        if (parola=="1234")
                        {
                            MessageBox.Show("Giriş Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Parola Hatalı!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı Hatalı!");
                    }
                }
    }
}
