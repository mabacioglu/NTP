using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ornek1
            /*
            string gun = Console.ReadLine();
            switch (gun)
            {
                case "1":
                    Console.WriteLine("Bugün günlerden PAZARTESİ");
                    break;
                case "2":
                    Console.WriteLine("Bugün günlerden SALI");
                    break;
                case "3":
                    Console.WriteLine("Bugün günlerden ÇARŞAMBA");
                    break;
                case "4":
                    Console.WriteLine("Bugün günlerden PERŞEMBE");
                    break;
                case "5":
                    Console.WriteLine("Bugün günlerden CUMA");
                    break;
                case "6":
                    Console.WriteLine("Bugün günlerden CUMARTESİ");
                    break;
                case "7":
                    Console.WriteLine("Bugün günlerden PAZAR");
                    break;
                default:
                    Console.WriteLine("LÜTFEN 1-7 ARASI BİR SAYI GİRİNİZ");
                    break;
            }*/
            #endregion
            #region Ornek2
            int gun = Convert.ToInt16(Console.ReadLine());
            switch (gun)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Hafta içindeyiz. OKULA devam");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Hafta sonundayız. Keyif Yap");
                    break;

                default:
                    Console.WriteLine("Hatalı giriş");
                    break;

            }


            #endregion


            Console.ReadKey();

        }
    }
}
