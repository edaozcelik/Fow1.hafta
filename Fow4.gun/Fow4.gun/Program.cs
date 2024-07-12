using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fow4.gun
{
    internal class Program
    {
        /*----------------------------------------
        static List<string> kitapList = new List<string>();

        static void Main(string[] args)
        {
            //kitaplık isminde liste olacak kitap ekle kitap çıkar kitapları listele
            //static void-fonksiyon
            // "\n" ile aynı konsolda bir satır altına yazdırabiliriz

            bool kontrol = true;
            while (kontrol)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
                Console.WriteLine("1. Kitap ekle");
                Console.WriteLine("2. Kitap sil");
                Console.WriteLine("3. Kitapları listele");
                Console.WriteLine("4. Çıkış yap");

                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        KitapEkle(kitapList);
                        break;

                    case "2":
                        KitapSil(kitapList);
                        break;

                    case "3":
                        KitaplariListele(kitapList);
                        break;

                    case "4":
                        Console.WriteLine("Çıkış yapılıyor");
                        kontrol = false;
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyiniz");
                        break;
                }
                
            }
            Console.Read();
        }

        static void KitapEkle(List<string> kitapList)
        {
            Console.WriteLine("Eklemek istediğiniz kitap: ");
            string kitap = Console.ReadLine();
            kitapList.Add(kitap);
        }

        static void KitapSil(List<string> kitapList)
        {
            for (int i = 0; i < kitapList.Count; i++)
            {
                Console.Write(i + 1 + "Kitaplarınız: " + kitapList[i]);
            }
            Console.WriteLine("Çıkartmak istediğiniz kitabı seçiniz: ");
            int numara = Convert.ToInt32(Console.ReadLine());
            kitapList.RemoveAt(numara-1);
        } 

        static void KitaplariListele(List<string> kitapList)
        { 
            for (int i = 0; i<kitapList.Count; i++)
            {
               Console.Write(i+1 + "Kitaplarınız: " + kitapList[i]);
            }
        }       
        ---------------------------------------------------*/
        // örnek 2
        /*------------------------------------------------
        static void Main(string[] args)
        {
            Console.WriteLine("1 mi 2 mi");
            int giris = Convert.ToInt32(Console.ReadLine());

            switch (giris)
            {
                case 1:
                    IlkFonk();
                    break;
                case 2:
                    Hesap();
                    break;
            }
            Console.Read();
        }

        static void IlkFonk()
        {
            Console.WriteLine("bir sayı gir");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi);
        }

        static void Hesap()
        {
            Console.WriteLine("1. sayi gir ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayi gir ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuc : " + (sayi + sayi2));
        }     
        ----------------------------------------------------*/

        //statik kullanımında tip varsa(int,string,char) "return" döndürmek gerek
        //örnek 1

        /*--------------------------------------------------
        static void Main(string[] args)
        {
            Console.WriteLine("Sonuc : " + (IlkFonk() + Ikinci()));

            Console.Read();
        }
        
        static int IlkFonk()
        {
            Console.WriteLine("1. sayiyi gir: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Ikinci()
        {
            Console.WriteLine("2. sayiyi gir: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static bool Kontrol()
        {

            return true;
        }  
        --------------------------------------------*/

        //örnek 2 // kendine bu tarz çıkmazlar yarat ve çıktıyı tahmin et
        /*-----------------------------------------------
        static void Main(string[] args)
        {
            Console.WriteLine(IlkFonk(5));

            Console.Read();
        }
        static int IlkFonk(int sayi)
        {
            sayi = Convert.ToInt32(Console.ReadLine());

            return sayi*10;
        }
        static int Ikinci(int sayi)
        {
            return 5 * IlkFonk(sayi);
        }     
        ------------------------------------------------*/

        //Switch taktiği ile hesap makinesi ve liste

        static void Main(string[] args)
        {
            bool kontrol = true;
            while (kontrol)
            {

                Console.WriteLine("Ne yapacaksın 1-Hesaplama.... 2-Liste İşlemleri..");
                int secenek = Convert.ToInt32(Console.ReadLine());

                if (secenek == 1)
                {
                    Console.WriteLine("1. Sayıyı giriniz: ");
                    int sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. Sayıyı giriniz: ");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n1.Toplama\n2.Çıkarma\n3.Çarpma\n4.Bölme");
                    Console.WriteLine("\nİşleminizi seçiniz: ");
                    int islem = Convert.ToInt32(Console.ReadLine());

                    switch (islem)
                    {
                        case 1:
                            Toplam(sayi1, sayi2);
                            break;
                        case 2:
                            Cikartma(sayi1, sayi2);
                            break;

                        case 3:
                            Carpma(sayi1, sayi2);
                            break;
                        case 4:
                            Bolme(sayi1, sayi2);
                            break;

                        default:
                            Console.WriteLine("Yanlış seçim yaptınız.");
                            break;


                    }
                }

                if (secenek ==2)
                {
                    List<string> kitapList = new List<string>();

                    Console.WriteLine("\n1.Kitap ekle\n2.Kitap sil\n3.Kitapları listele\n4.Çıkış yap");
                    Console.WriteLine("\nİşleminizi seçiniz: ");

                    string secim = Console.ReadLine();
                    switch (secim)
                    {
                        case "1":
                            KitapEkle(kitapList);
                            break;

                        case "2":
                            KitapSil(kitapList);
                            break;

                        case "3":
                            KitaplariListele(kitapList);
                            break;

                        case "4":
                            Console.WriteLine("Çıkış yapılıyor");
                            kontrol = false;
                            break;

                        default:
                            Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyiniz");
                            break;
                    }
                }

            }
        }
        static void Toplam(int sayi1, int sayi2)
        {
            Console.WriteLine("İslemin sonucu = " + (sayi1 + sayi2));
            return;
        }
        static void Cikartma(int sayi1, int sayi2)
        {
            Console.WriteLine("İslemin sonucu = " + (sayi1 - sayi2));
            return;
        }
        static void Carpma(int sayi1, int sayi2)
        {
            Console.WriteLine("İslemin sonucu = " + (sayi1 * sayi2));
            return;
        }
        static void Bolme(int sayi1, int sayi2)
        {
            Console.WriteLine("İslemin sonucu = " + (sayi1 / sayi2));
            return;
        }


        static void KitapEkle(List<string> kitapList)
        {
            Console.WriteLine("Eklemek istediğiniz kitap: ");
            string kitap = Console.ReadLine();
            kitapList.Add(kitap);
        }

        static void KitapSil(List<string> kitapList)
        {
            for (int i = 0; i < kitapList.Count; i++)
            {
                Console.Write(i + 1 + "Kitaplarınız: " + kitapList[i]);
            }
            Console.WriteLine("Çıkartmak istediğiniz kitabı seçiniz: ");
            int numara = Convert.ToInt32(Console.ReadLine());
            kitapList.RemoveAt(numara - 1);
        }

        static void KitaplariListele(List<string> kitapList)
        {
            for (int i = 0; i < kitapList.Count; i++)
            {
                Console.Write(i + 1 + "Kitaplarınız: " + kitapList[i]);
            }
        }
    }
}
