using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oyuncuPuan = 0;
            int bilgisayarPuan = 0;
           
            while (oyuncuPuan < 5 && bilgisayarPuan < 5)
            {
                Console.WriteLine("Bir secim yapiniz: tas(t), kagit(k), makas(m) ");
                string secim = Console.ReadLine();

                if (secim != "t" && secim != "k" && secim != "m")
                {
                    Console.WriteLine("yanlis secim yapildi");
                    return;
                }
                if (secim == "t")
                {
                    Console.WriteLine("Seciminiz: tas");
                }
                else if (secim == "k")
                {
                    Console.WriteLine("Seciminiz: kagit");
                }
                else if (secim == "m")
                {
                    Console.WriteLine("Seciminiz: makas");
                }
                else
                {
                    Console.WriteLine("Yanlis secim yapildi");
                }

                Random rand = new Random();
                int bilgisayarSecimi = rand.Next(1, 4);

                switch (bilgisayarSecimi)
                {
                    case 1:
                        Console.WriteLine("Bilgisayar secimi: tas");
                        break;
                    case 2:
                        Console.WriteLine("Bilgisayar secimi: kagit");
                        break;
                    case 3:
                        Console.WriteLine("Bilgisayar secimi: makas");
                        break;
                    default:
                        Console.WriteLine("hata");
                        break;
                }


                if ((secim == "t" && bilgisayarSecimi == 1)||
                    (secim == "k" && bilgisayarSecimi == 2)||
                    (secim == "m" && bilgisayarSecimi == 3))
                {
                    Console.WriteLine("berabere\n");
                    oyuncuPuan += 0;
                    bilgisayarPuan += 0;
                }
                else if ((secim == "t" && bilgisayarSecimi == 2)||
                        (secim == "k" && bilgisayarSecimi == 3)||
                        (secim == "m" && bilgisayarSecimi == 1))
                {
                    Console.WriteLine("bilgisayar aldi\n");
                    oyuncuPuan += 0;
                    bilgisayarPuan += 1;
                }
                else if ((secim == "t" && bilgisayarSecimi == 3)||
                        (secim == "k" && bilgisayarSecimi == 1)||
                        (secim == "m" && bilgisayarSecimi == 2))
                {
                    Console.WriteLine("oyuncu aldi\n");
                    oyuncuPuan += 1;
                    bilgisayarPuan += 0;
                }
               
                else
                {
                    Console.WriteLine("hata");
                    return;
                }
            }
            if (oyuncuPuan == 5)
            {
                Console.WriteLine("Tebrikler Kazandiniz!\n");
                return;
            }
            else if (bilgisayarPuan == 5)
            {
                Console.WriteLine("Bilgisayar kazandi Daha iyi sanslar!\n");
                return;
            }
            else
            {
                Console.WriteLine("Berabere kaldiniz!\n");
                return;
            }
        }
    }
}