using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03__HATA_TÜRLERİ
{
    class Program
    {
        static void Main(string[] args)
        {
            // HATA TÜRLERİ


            #region 1- Syntax Error / Sözdizimi Hatası
           // int a=10,
           // Int x=20;
           // int sonuc=3*(15+25));

            #endregion
            #region 2- Runtime Error / Çalışma Zamanı hatası
            //int a;
            //Console.Write("Bir sayı giriniz");
            //a = Convert.ToInt32(Console.ReadLine());
            //int karesi = a * a;
            //Console.WriteLine(karesi);

            #endregion
            #region 3- Logic Error / Mantık hatası
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("İki sayının toplamı= {0}",sonuc);
            #endregion

            Console.ReadKey();
        }
    }
}
