using System;

namespace SecondDayHomeworkSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Gamepower Medusa Rainbow";
            urun1.Satici = "Aptek";
            urun1.Fiyati = 239;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Steelseries Arctis 1";
            urun2.Satici = "İtopya";
            urun2.Fiyati = 599;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Razer Kraken";
            urun3.Satici = "İtopya";
            urun3.Fiyati = 785;


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " | " + urun.Satici + " | Fiyatı: " + urun.Fiyati + " TL");
            }

          




        }

    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public string Satici { get; set; }
        public int Fiyati { get; set; }
    }

}

     
