using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_METOTLAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Toplama();
            Deneme();
            Console.WriteLine("Main metodu çalıştı");
            Deneme2();
            Deneme2();
            Toplama();
            Deneme2();
            Console.ReadKey();
        }
        static void Deneme() 
        {
            Console.WriteLine("Deneme metodu çalıştı");
        }
        static void Deneme2() 
        {
            Console.Write("Adınızı Giriniz :");
            string ad = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz :");
            string soyad = Console.ReadLine();
            Console.WriteLine("Hoşgeldin " + ad + " " + soyad);
        }
        static void Toplama() {
            int sayi1, sayi2, sonuc;
            sayi1 = int.Parse(Console.ReadLine());
            sayi2 = int.Parse(Console.ReadLine());
            sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuç = "+sonuc);
        }
        
        
    }
}
