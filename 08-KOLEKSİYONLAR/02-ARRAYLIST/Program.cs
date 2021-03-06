using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  // ArrayList kullanmak için gereklidir.

namespace _02_ARRAYLIST
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dinamikListem = new ArrayList();
            dinamikListem.Add("mehmet");   // listenin sonuna ekler
            dinamikListem.Add(10);
            dinamikListem.Add(true);
            dinamikListem.Add(3.14f);
            
            foreach (object item in dinamikListem)
            {
                Console.WriteLine(item);
            }

            int sonuc = (int)dinamikListem[1] * 2; // unboxing
            Console.WriteLine(sonuc);
            float sonuc1 = (float)dinamikListem[3] * 2;
            Console.WriteLine(sonuc1);
            dinamikListem[0] = "ahmet";  // var olan elemanın değerini değiştirir
            Console.WriteLine(dinamikListem[0]);
            Console.WriteLine("----------------------------");
            dinamikListem.Insert(2, "yeni eleman"); // 2 numaralı indise eleman ekler, diğer elemanlar ötelenir
            foreach (object item in dinamikListem)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("----------------------------");
            dinamikListem.Remove("ahmet");  // girilen değerdeki  elemanı siler, diğer elemanlar ötelenir
            foreach (object item in dinamikListem)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");
            dinamikListem.RemoveAt(2);   // girilen indisteki eleman silinir. diğer elemanlar ötelenir.
            foreach (object item in dinamikListem)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
