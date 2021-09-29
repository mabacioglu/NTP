using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEĞİŞKENLER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DEĞİŞKENLER
            // İKİ TİP DEĞİŞKEN VARDIR
            // 1- Değer Tipler
            // 2- Referans Tipler

            // DEĞER TİPLERİ
            // 1- TAM SAYI TİPLER
            // 2- ONDALIKLI SAYI TİPLERİ
            // 3- METİNSEL TİPLER
            // 4- KARAKTER TİPLİ DEĞİŞKENLER
            // 5- MANTIKSAL TİPLİ DEĞİŞKENLER
            #region 1- TAM SAYI TİPLER
            //byte,short,int,long,sbyte,ushort,uint,ulong
          
            //MinValue , MaxValue, sizeof()

            //MessageBox.Show("byte tipinin alabileceği en küçük değer:  " + byte.MinValue + 
            //    "\nbyte tipinin alabileceği en büyük değer:  "+byte.MaxValue+
            //    "\nbyte tipinin RAM de kapladığı alan(byte cinsinden): " + sizeof(byte));
            
            //MessageBox.Show("short tipinin alabileceği en küçük değer:  " + short.MinValue +
            //   "\nshort tipinin alabileceği en büyük değer:  " + short.MaxValue +
            //   "\nshort tipinin RAM de kapladığı alan(byte cinsinden): " + sizeof(short));
           
            //MessageBox.Show("int tipinin alabileceği en küçük değer:  " + int.MinValue +
            //  "\nint tipinin alabileceği en büyük değer:  " + int.MaxValue +
            //  "\nint tipinin RAM de kapladığı alan(byte cinsinden): " + sizeof(int));
            
            //MessageBox.Show("long tipinin alabileceği en küçük değer:  " + long.MinValue +
            //  "\nlong tipinin alabileceği en büyük değer:  " + long.MaxValue +
            //  "\nlong tipinin RAM de kapladığı alan(byte cinsinden): " + sizeof(long));

            #endregion
            #region 2- ONDALIKLI SAYI TİPLERİ
            // float, double, decimal
            //MessageBox.Show("double tipinin alabileceği en küçük değer:  " + double.MinValue +
            //    "\ndouble tipinin alabileceği en büyük değer:  " + double.MaxValue +
            //    "\ndouble tipinin RAM de kapladığı alan(byte cinsinden): " + sizeof(double));

            float x = 3.1456f;
            double y = 3.456874d;
            decimal z = 3.549845m;

            #endregion
            #region 3- METİNSEL TİPLER
            //string
            string ad;
            ad = "Mehmet";
            string soyad = "Abacıoğlu";

            string sayi1 = "3";
            string sayi2 = "4";
            string sonuc1=sayi1+sayi2;
            MessageBox.Show(sonuc1);

            int sayi3 = 3;
            int sayi4 = 4;
            int sonuc = sayi3 + sayi4;
            MessageBox.Show(""+sonuc);

            #endregion
            #region 4- KARAKTER TİPLİ DEĞİŞKENLER
            // char
            char karakter='e';

            #endregion
            #region 5- MANTIKSAL TİPLİ DEĞİŞKENLER
            // bool
            bool cocukVarMi;
            cocukVarMi = true;
            #endregion

            #region Değişken Tanımlama Kuralları
            //1- C# programlama dili büyük harf küçük harf duyarlıdır.
            int sayi=9;
            int Sayi=10;
            
            // 2- Değişkeninin ilk karakteri harf veya _ olmalıdır.
            string Ad; // doğru
            int 1ahmet; // yanlış
            byte _maas; // doğru
            short maas_farki; // doğru

            // 3- Değişken adı kullanırken boşluk bırakılmaz.
            decimal maas farki; //yanlış
            decimal maas-farki; //yanlış

            // 4- Değişken tanımlarken _ dışında hiç bir özel karakter kullanılmaz.(*/-+.,!'+%)
            char *karakter; //yanlış
            int sayi1; // doğru
            int 1sayi; //yanlış

            // 5- Programda kullanılan kodlar(özel deyimler) değişken adı olarak kullanılamaz.

            int if;
            string char;
            double for;
            float true;

            // 6- Değişken tanımlarken Türkçe karakter kullanmamalıyız. (ç,ğ,ş,ı,ö,ü,Ç,Ğ,İ,Ş,Ö,Ü)
            decimal maas;



            
           
            
            #endregion

        }    }
}