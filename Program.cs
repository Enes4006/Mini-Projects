using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kacAtis, zar1,zar2;

            int oyuncu = 0, bilgisayar = 0;

            Console.WriteLine("Kac defa atis olacak?: ");
            kacAtis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(kacAtis + " atis olacak\n");

            Random rand = new Random();

            for (int i = 0; i < kacAtis; i++)
            {
                
                zar1 = rand.Next(1, 7);
                zar2 = rand.Next(1, 6);
                Console.WriteLine("Oyuncu: "+zar1);
                Console.WriteLine("Bilgisayar: " + zar2);


                if (zar1 > zar2)
                {
                    Console.WriteLine("Oyuncu 1 puan kazandi\n");
                    oyuncu += 1;
                }
                else if (zar2 > zar1)
                {
                    Console.WriteLine("Bilgisayar 1 puan kazandi\n");
                    bilgisayar += 1;
                }
                else
                {
                    Console.WriteLine("Berabere\n");
                }
            }

            if(oyuncu>bilgisayar)
            {
                Console.WriteLine("Oyuncu kazandi!!!");
            }
            else if(oyuncu>bilgisayar)
            {
                Console.WriteLine("Bilgisayar kazandi!!!");
            }
            else
            {
                Console.WriteLine("Berabere kaldiniz!!!");
            }
            
        }
    }
}
