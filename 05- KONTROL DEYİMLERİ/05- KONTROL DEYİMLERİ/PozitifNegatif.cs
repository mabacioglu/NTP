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
    public partial class PozitifNegatif : Form
    {
        /*
        if (koşul)
    {
     koşul true ise çalışacak kodlar
    }

        */
        public PozitifNegatif()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int girilenSayi;
            girilenSayi = int.Parse(txtGirilenSayi.Text);
           
            if (girilenSayi > 0)
            {
                MessageBox.Show("Girilen sayı POZİTİFTİR");
                
            }

            if (girilenSayi<0)
                MessageBox.Show("Girilen sayı NEGATİFTİR"); // EĞER ÇALIŞTIRILACAK KOD TEK SATIRSA SÜSLÜ PARANTEZ KULLANMAYABİLİRİZ.


            if (girilenSayi == 0)
            { MessageBox.Show("Girilen sayı SIFIRDIR"); }
        }
    }
}
