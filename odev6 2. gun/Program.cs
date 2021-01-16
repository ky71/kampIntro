using System;

namespace odev6_2._gun
{
    class Program
    {
        static void Main(string[] args)
        {

            Urunler Urun1 = new Urunler();
            Urun1.UrunAdi = "Ceket";
            Urun1.UrunFiyati = 50;
            Urun1.UrunBoyutu = "L";

            Urunler urun2 = new Urunler();
            urun2.UrunAdi = "pantolon";
            urun2.UrunFiyati = 100;
            urun2.UrunBoyutu = "XL";

            Urunler urun3 = new Urunler();
            urun3.UrunAdi = "tshirt";
            urun3.UrunFiyati = 20;
            urun3.UrunBoyutu = "S";

            Urunler[] urun = new Urunler[] { Urun1, urun2, urun3 };

            Console.WriteLine("........FOREACH.......");
            foreach (var a in urun)
            {
                Console.WriteLine(a.UrunAdi);
                Console.WriteLine(a.UrunBoyutu);
                Console.WriteLine(a.UrunFiyati);
                Console.WriteLine("\n");

            }

            Console.WriteLine(".......FOR........");

            for (int i = 0; i < urun.Length; i++)
            {

                Console.WriteLine(urun[i].UrunAdi);
                Console.WriteLine(urun[i].UrunBoyutu);
                Console.WriteLine(urun[i].UrunFiyati);
                Console.WriteLine("\n");
             
            }

            Console.WriteLine("..............WHİLE.........");

            int d = 0;
            while (d<3)
            {
                Console.WriteLine(urun[d].UrunAdi);
                Console.WriteLine(urun[d].UrunBoyutu);
                Console.WriteLine(urun[d].UrunFiyati);
                Console.WriteLine("\n");

                d++;
            }



        }
    }


    class Urunler
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
        public string UrunBoyutu { get; set; }
    }

}
