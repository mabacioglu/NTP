using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CLASS_YAPISI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
            Ogrenci ogr1 = new Ogrenci();
            ogr1.ad = "mehmet";
            ogr1.soyad = "abacıoğlu";
            ogr1.numara = "855";
            ogr1.yas = 16;

            Ogrenci ogr2 = new Ogrenci();
            ogr2.ad = "ayşe";
            ogr2.soyad = "yılmaz";
            ogr2.numara = "1001";
            ogr2.yas = 17;

            ogrenciListesi.Add(ogr1);
            ogrenciListesi.Add(ogr2);
            foreach (Ogrenci item in ogrenciListesi)
            {
                Console.WriteLine(item.numara+" "+item.ad+" "+item.soyad);
            }

            Ogretmen ogrt1 = new Ogretmen();
            ogrt1.ad = "Özkan";
            ogrt1.soyad = "Göktaş";
            ogrt1.Ekle();

            Ogretmen ogrt2 = new Ogretmen();
            ogrt2.ad = "Erdoğan";
            ogrt2.soyad = "Yurdakul";
            ogrt2.Ekle();
           
           
           
            Console.ReadKey();
        }
    }
    
}
