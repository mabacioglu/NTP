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
    public partial class Form3 : Form
    {
        public Form3()
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
            catch (DivideByZeroException)  // hata olduğu durumda çalışacak yer: sıfıra bölünme hatası
            {
                MessageBox.Show("Hiç bir sayı Sıfıra bölünemez, Lütfen Doğru giriş yapınız.. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)  // hata olduğu durumda çalışacak yer : yanlış formatta giriş
            {
                MessageBox.Show("Lütfen sadece rakam girişi yapınız.. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)  // hata olduğu durumda çalışacak yer : değişkenini taşıyamayacağı değer girildiğinde
            {
                MessageBox.Show("Girdiğiniz sayı çok büyük. Lütfen tekrar deneyiniz.. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ee)  // hata olduğu durumda çalışacak yer
            {
                MessageBox.Show(ee.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally // iki bloktan hangisi çalışırsa çalışsın bu blok sonrasında çalışır
            {
                txtSayi1.Text = "";
                txtSayi2.Text = null;
            }
        }

        
    }
}
