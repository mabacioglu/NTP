using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORLER
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPERATÖRLER
            #region 1- ARİTMETİKSEL OPERATÖRLER
            // + ,  - ,  * ,  / ,  %
            //Console.WriteLine(3+8);
            //Console.WriteLine(10-8);
            //Console.WriteLine(2*8);
            //Console.WriteLine(10/5);
            //Console.WriteLine(10%3);
            //Console.WriteLine(45%35);
            #endregion
            #region 2- ATAMA VE ARTIRMA OPERATÖRLERİ
            // = , ++ , -- ,+= ,-= , *=  , /= , %=
            //int a,b;
            //a = 25;
            //b = a + 2;
            //b = b + 8;
            //a = a + 1;
            //Console.WriteLine("a= "+a);
            //Console.WriteLine("b= "+b);
            //a++; 
            //b--;
            //Console.WriteLine("a= " + a);
            //Console.WriteLine("b= " + b);
            //a += 3;  //   a = a + 3
            //b -= 5;
            //Console.WriteLine("a= " + a);
            //Console.WriteLine("b= " + b);
            //b %= 5;
            //Console.WriteLine("b= " + b); //  b = b % 5
            #endregion
            #region 3- KARŞILAŞTIRMA OPERATÖRLERİ
            // < , > , <= , >= , == , !=
            
            Console.WriteLine(3<5);
            Console.WriteLine(5==6);
            Console.WriteLine("mehmet"=="Mehmet");
            Console.WriteLine(4!=5);
            #endregion

            Console.ReadKey();
        }
    }
}
