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
    public partial class TakdirTesekkur : Form
    {
        public TakdirTesekkur()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            int ortalama;
            ortalama = int.Parse(textBox1.Text);
           /* if (ortalama < 0 || ortalama > 100)
            {
                MessageBox.Show("Ortalama 0-100 aralığında olmalıdır");
            }

            if (ortalama>=0 && ortalama<50)
            {
                MessageBox.Show("KALDINIZ");
            }
            if (ortalama >=50 && ortalama<70)
            {
                MessageBox.Show("DİREK GEÇTİNİZ");
            }
            if (ortalama>=70 && ortalama<85)
            {
                MessageBox.Show("TEŞEKKÜR ALDINIZ");
            }
            if (ortalama>=85 && ortalama<=100)
            {
                MessageBox.Show("TAKDİR ALDINIZ");
            }
             */
            if (ortalama < 0 )
            {
                MessageBox.Show("Lütfen 0 dan büyük bir sayi giriniz");
            }
            else if (ortalama < 50)
            {
                MessageBox.Show("KALDINIZ");
            }
            else if (ortalama<70)
            {
                MessageBox.Show("DİREK GEÇTİNİZ");
            }
            else if (ortalama<85)
            {
                MessageBox.Show("TEŞEKKÜR ALDINIZ");
            }
            else if (ortalama<=100)
            {
              MessageBox.Show("TAKDİR ALDINIZ");  
            }
            else
            {
                MessageBox.Show("Lütfen 100 den küçük bir sayı giriniz");
            }


        }
    }
}
