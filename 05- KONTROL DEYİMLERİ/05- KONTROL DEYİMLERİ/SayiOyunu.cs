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
    public partial class SayiOyunu : Form
    {
        public SayiOyunu()
        {
            InitializeComponent();
        }
        int tutulanSayi;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            tutulanSayi = rastgele.Next(1,100);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahminEdilenSayi=int.Parse(txtTahminEdilenSayi.Text);
            if (tahminEdilenSayi == tutulanSayi) 
            {
                MessageBox.Show("Tebrikler   !!!  \n Sayıyı bildiniz !!!");
                txtTahminEdilenSayi.Enabled = false;
                button1.Enabled = false;
            }

            if (tahminEdilenSayi < tutulanSayi)
            {
                MessageBox.Show("Lütfen Daha BÜYÜK Bir Sayı Deneyiniz");
            }

            if (tahminEdilenSayi > tutulanSayi)
            {
                MessageBox.Show("Lütfen Daha KÜÇÜK Bir Sayı Deneyiniz");
            }
        }
    }
}
