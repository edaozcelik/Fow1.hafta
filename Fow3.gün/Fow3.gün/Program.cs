using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Fow3.gün
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*while (true)
           {
               int[] arr = new int[10];
               int toplam = 0;

               for (int i = 0; i < 10; i++)
               {
                   Console.Write((i + 1) + ".Birinci sayıyı giriniz : ");
                   int girilen = Convert.ToInt32(Console.ReadLine());
                   arr[i] = girilen;
                   toplam += girilen;
               }
               for(int i = 0;i < arr.Length; i++)
               {
                   Console.Write("dizinin" + (i+1) + ". elemanı" + arr[i]);
               }
               Console.WriteLine("Toplam = " + toplam);  

               Console.Read(); */

            //kullanıcıdan 10 sayı al en büyük ve en küçüğü bul

            /*int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            int toplam = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + ".Birinci sayıyı giriniz : ");
                int girilen = Convert.ToInt32(Console.ReadLine());
                toplam += girilen;

                if (girilen > maxNumber)
                {
                    maxNumber = girilen;
                }
                else if (girilen < minNumber)
                {
                    minNumber = girilen;
                }
            }
            Console.WriteLine("En büyük = " + maxNumber + " En küçük = " + minNumber); */

            //alfabeyi tersine çevir

            /*string[] dizi = { "a", "b", "c", "d", "e", "f", "g", "h" };
            string[] ters = new string[dizi.Length];

            for (int i = 0; i < dizi.Length; i++)
            {
                ters[i] = dizi[dizi.Length-1-i];
            }
            for (int i = 0; i < ters.Length; i++)
            {
                Console.WriteLine(dizi[i] + " " + ters[i]);
            }  */

            /*int sayi1 = 5;
            int sayi2 = sayi1;
            sayi1 = 10;
            Console.WriteLine(sayi2);

            int[] dizi1 = {1,2,3,4,5};
            int[] dizi2 = dizi1;
            dizi1[1] = 10;
            Console.WriteLine(dizi2[1]); */

            //sayı tahmin oynu

            /*Random rnd=new Random();
            int Rastgele=rnd.Next(0,100);

            while(true)
            {
                Console.WriteLine("Tahmin giriniz: ");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                
                if(tahmin < Rastgele)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz");
                }
                else if(tahmin > Rastgele)
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz");
                }
                else
                {              
                    Console.WriteLine("Tebrikler!");
                }
            }          */

            /*List<string> listem = new List<string>();
            listem.Add("Ankara");
            listem.Add("İstanbul");
            listem.Add("İzmir");
            listem.Remove("Eskişehir");
            listem.RemoveAt(2);

            bool kontrol = listem.Contains("Bursa");

            Console.WriteLine(listem.Contains("Bursa"));

            for (int i = 0; i < listem.Count; i++)
            {
                Console.WriteLine(listem[i]);
            }    */

            //kullanıcıdan 10 sayı istenecek verilen 10 sayının en küçüğü ve en büyüğü

            /*int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i+1) + ". sayıyı girin: ",  i+1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int enBuyuk =sayilar[0];
            int enKucuk =sayilar[0];
            for (int i = 0;i < 10;i++)
            {
                if (sayilar[i] > enBuyuk)
                    enBuyuk = sayilar[i];

                if (sayilar[i] < enKucuk)
                    enKucuk = sayilar[i];
            }

            Console.WriteLine("Girilen en küçük sayı={0}", enKucuk);
            Console.WriteLine("Girilen en büyük sayı={0}", enBuyuk);

            Console.Read();*/

            //kullanıcıdan 10 sayı istenecek verilen 10 sayı küçükten büyüğe

            /*List<int> listem = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+1 + ".Sayıyı Giriniz:");
                int girilen = Convert.ToInt32(Console.ReadLine());
                listem.Add(girilen);
            }
            for (int i = 0; i < listem.Count; i++)
            {
                for (int j = i + 1; j < listem.Count; j++)
                {
                    if (listem[i] > listem[j])
                    {
                        int gecici = listem[j];
                        listem[j] = listem[i];
                        listem[i] = gecici;
                    }
                }
            }
            Console.WriteLine("Girilen Sayıların Küçükten Büyüğe: ");
            for (int i = 0; i < listem.Count; i++)
            {
                Console.WriteLine(listem[i]);
            }
            Console.ReadKey();  */

        }

    }
    
}
