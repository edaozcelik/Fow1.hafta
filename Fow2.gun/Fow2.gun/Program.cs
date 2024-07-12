using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fow2.gun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hesap makinesi yapımı

            /*double sayi1;
            double sayi2;
            Console.Write("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İşlem seç : (+, -, *, /) : ");
            char secim =Convert.ToChar (Console.ReadLine());

            if (secim == '+')
            {
                Console.WriteLine("Toplam : " + (sayi1 + sayi2));
            }
            else if (secim == '-')
            {
                Console.WriteLine("Fark : " + (sayi1 - sayi2));
            }
            else if (secim == '*')
            {
                Console.WriteLine("Çarpım : " + sayi1 * sayi2);
            }
            else if (secim == '/')
            {
                Console.WriteLine("Bölüm : " + sayi1 / sayi2);
            }
            else                 //hepsinin dışında anlamına gelir
            {
                Console.WriteLine("Yanlış işlem seçildi....!!!");
            }

            while (true)   //programı sonsuz döngüye sokar "break" ile de döngüyü kır
            {
                Console.WriteLine("merhabaaa");
                break;
            } */

            //bankamatik yapımı

            /*int bakiye = 1000;
            bool devam = true;
            while (devam)
            { 
                Console.WriteLine("İşlem seçiniz : 1-Para çek, 2-Para yatır, 3-Bakiye gör, 4-Çıkış" );
                int secim =Convert.ToInt32 (Console.ReadLine());

                if (secim == 1)
                {
                    Console.WriteLine("Tutar giriniz: ");
                    int cekilen =Convert.ToInt32 (Console.ReadLine());
                    if (cekilen > bakiye)
                    {
                        Console.WriteLine("Yetersiz bakiye...");
                    }
                    else
                    {
                        bakiye -= cekilen;
                        Console.WriteLine("Çekim işlemi yapıldı. İyi günler");
                    }
                    
                }
                else if (secim == 2)
                {
                    Console.WriteLine("Tutar giriniz: ");
                    int yatırılan = Convert.ToInt32(Console.ReadLine());
                    bakiye += yatırılan;
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Bakiye : " + bakiye);
                }
                else if (secim == 4)
                {
                    devam = false;
                }
            }
            Console.WriteLine("Çıkış Yapıldı. İyi günler canım...."); */

            //örnek 1

            /*while (true)
            {
                Console.WriteLine("Bir kelime giriniz : ");
                string kelime = Console.ReadLine();
                if (kelime == "tamam")
                {
                    Console.WriteLine("Görev tamamlandı");
                    break;
                }
                Console.WriteLine("Girdiğin kelime : " + kelime);

            }                                  */
            //Benim yaptığım

            /*for (int i = 0; i <= 1000; i++)
                Console.WriteLine(i % 7);

            //Hocanın yaptığı
            int sayi = 0;
            while (sayi < 1000)
            {
                Console.WriteLine(sayi + "sayısının mod 7si" + sayi % 7);
                sayi++;
            }     */

            //örnek 2

            /*bool devam = true;
            while (devam)
            {
                double sayi1;
                double sayi2;
                Console.Write("Birinci sayıyı giriniz: ");
                sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayıyı giriniz: ");
                sayi2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İşlem seç : (+, -, *, /) : ");
                char secim = Convert.ToChar(Console.ReadLine());

                switch (secim)
                {
                    case '+':
                        Console.WriteLine("Toplam : " + (sayi1 + sayi2));
                        break;
                    case '-':
                        Console.WriteLine("Fark : " + (sayi1 - sayi2));
                        break;
                    case '*':
                        Console.WriteLine("Çarpım : " + sayi1 * sayi2);
                        break;
                    case '/':
                        if (sayi2 != 0)
                        {
                            Console.WriteLine("Bölüm : " + sayi1 / sayi2);
                        }
                        else
                        {
                            Console.WriteLine("Hata: Bir sayi sıfıra bölünemez!");
                        }
                        break;
                    default:
                        Console.WriteLine("Gecersiz islem!");
                        devam = false;
                        break;            */
            //For Döngüsü

            /*for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1 + "Merhaba");
            }  */

            /*int toplam = 0; 

            for (int i = 0;i < 10; i++)
            {
                Console.Write((i+1) + ".Birinci sayıyı giriniz : ");
                int girilen = Convert.ToInt32(Console.ReadLine());

                toplam += girilen;
            }

            Console.WriteLine("Toplam = " + toplam);  */

            while (true)
            {
                int fakt = 1;
                Console.WriteLine("Bir sayı giriniz: ");
                int girilen = Convert.ToInt32(Console.ReadLine());


                for (int i = girilen; i > 1; i--)
                {
                    fakt *= i;
                }

                Console.WriteLine("sonuc = " + fakt);

            }

            Console.Read();
               
        }
        
    }
}
