using Fow5.gun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fow5.gun
{
    //çevre hesaplama ikiz kenar kontrol(üçgenin) 1-2-3 kenarlar kullanıcıdan alınacak
    /*-----------------------------------------------------------------------
    public class Ucgen
    {
        private double Kenar1;
        private double Kenar2;
        private double Kenar3;

        public Ucgen(double kenar1, double kenar2, double kenar3)
        {
            this.Kenar1 = kenar1;
            this.Kenar2 = kenar2;
            this.Kenar3 = kenar3;
        }
        public double CevreHesap()
        {
            return Kenar1 + Kenar2 + Kenar3;
        }
        public bool IkizKontrol()
        {
            return (Kenar1 == Kenar2 || Kenar2 == Kenar3 || Kenar1 == Kenar3);
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Birinci kenar uzunluğunu giriniz cnm: ");
                double kenar1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("İkiinci kenar uzunluğunu giriniz cnm: ");
                double kenar2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Üçüncü kenar uzunluğunu giriniz cnm: ");
                double kenar3 = Convert.ToDouble(Console.ReadLine());

                Ucgen ucgen1 = new Ucgen(kenar1, kenar2, kenar3);

                double cevre = ucgen1.CevreHesap();
                bool Ikizkenar = ucgen1.IkizKontrol();

                Console.WriteLine("Üçgenin çevresi: " + cevre);
                if (Ikizkenar)
                {
                    Console.WriteLine("Üçgen ikizkenardır");
                }
                else
                {
                    Console.WriteLine("Üçgen ikizkenar değil");
                }
                Console.Read();
            }

        }
    } 
    --------------------------------------------------*/

    // üniversite listesi yapılacak isim yıl şehir kullanıcıdan ekleme silme arama listeleme

    public class University
    {
        public string Name;
        public int Year;
        public string City;

        public University(string isim, int yil, string sehir)
        {
            Name = isim;
            Year = yil;
            City = sehir;
        }
        public void IsimYaz()
        {
            Console.WriteLine(Name);
        }
        public void YilYaz()
        {
            Console.WriteLine(Year);
        }
        public void SehirYaz()
        {
            Console.WriteLine(City);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<University> uniListesi = new List<University>();

            Console.WriteLine("1-Uni Ekle  2-Uni Sil  3-Uni Ara  4-Uni Listele  5-Çık");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine("Universite adı: ");
                    string ad = Console.ReadLine();
                    Console.WriteLine("Yılı: ");
                    int yil = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Şehri: ");
                    string sehir = Console.ReadLine();

                    University yeni = new University(ad,yil,sehir);
                    uniListesi.Add(yeni);
                    break;
                case 2:

                    break;
                case 3:
                    Console.WriteLine("Aramak istediğin uni adını gir: ");
                    string aranan = Console.ReadLine();

                    bool bulundu = false;

                    for (int i = 0; i < uniListesi.Count; i++)
                    {
                        University yeni2 = uniListesi[i];

                        if (aranan == yeni2.Name)
                        {
                            yeni2.IsimYaz();
                            yeni2.YilYaz();
                            yeni2.SehirYaz();
                            Console.WriteLine("-----------------------");

                            bulundu = true;
                        }

                    }
                    if (!bulundu)
                    {
                        Console.WriteLine("Bulunmadı...");
                    }

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }
    }
}