using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtmProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 100;
            int secim;

            int atmSifre = 12345;

            Console.WriteLine("Sifreyi giriniz: ");
            int sifre = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Telefonunuzu giriniz: ");
            string telno = Convert.ToString(Console.ReadLine());

            
            Random rastgele = new Random();
            Console.WriteLine("Telefon numaraniza dogrulama kodu gonderildi.");
            

            int rastgelee=rastgele.Next(1,10);
            Console.WriteLine(rastgelee);

            Console.WriteLine("Dogrulama kodunu giriniz: ");
            int dKodu=int.Parse(Console.ReadLine());

            if (dKodu==rastgelee)
            {
                Console.WriteLine("Kod doğru\n");
                if (sifre == atmSifre)
                {
                    do
                    {
                        Console.WriteLine("ATM Projesi\n");
                        Console.WriteLine("1:Bakiye Goruntule");
                        Console.WriteLine("2.Para Yatirma");
                        Console.WriteLine("3.Para Cekme");
                        Console.WriteLine("4.Cikis\n");

                        Console.WriteLine("Lutfen isim giriniz: ");
                        string isim = Console.ReadLine();
                        Console.WriteLine("Merhaba " + isim+"\n");

                        Console.WriteLine("Seciminizi girin");
                        secim = int.Parse(Console.ReadLine());
                        Console.WriteLine("Seciminiz: " + secim);

                        switch (secim)
                        {
                            case 1:
                                Console.WriteLine("Bakiyeniz: " + bakiye+"\n");
                                break;
                            case 2:
                                Console.WriteLine("Ne kadar para yatiracaksiniz?: ");
                                int yatirma = int.Parse(Console.ReadLine());
                                bakiye += yatirma;
                                Console.WriteLine(yatirma + " tl para yatirildi");
                                Console.WriteLine("Bakiyeniz: " + bakiye + " tl");
                                break;
                            case 3:
                                Console.WriteLine("Ne kadar para cekeceksiniz?: ");
                                int cekme = int.Parse(Console.ReadLine());

                                if (cekme > bakiye)
                                {
                                    Console.WriteLine("Yetersiz bakiye !!");
                                }
                                else
                                {
                                    bakiye -= cekme;
                                    Console.WriteLine(cekme + " tl para cekildi");
                                    Console.WriteLine("Bakiyeniz: " + bakiye);
                                }
                                break;
                            case 4:
                                Console.WriteLine("Cikis yapiliyor..");
                                break;
                            default:
                                Console.WriteLine("Gecersiz islem");
                                break;
                        }

                    }
                    while (secim != 4);
                }
                else
                {
                    Console.WriteLine("Sifre yanlis !!!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Kod yanlis !!! ");
                return;
            }
        }
    }
}
