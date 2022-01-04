using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DİZİLER
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                sayilar[i] = i * i;
            }

            Console.WriteLine("-------------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            sayilar[3] = 10;

            Console.WriteLine("-------------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            sayilar[2] = sayilar[1] + sayilar[3];
            Console.WriteLine("-------------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

           // sayilar[5] = 25;   Hatalı
            Console.WriteLine("-------------");
            string[] isimler = new string[] { "mehmet", "özkan", "ali", "veli" };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            Console.WriteLine("-------------");
            int[] sayilar2 = { 5, 6, 7, 8, 9 };
            
            foreach (int item in sayilar2)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
