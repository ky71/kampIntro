using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Açiklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Açiklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            // type safe-- tip güvenli Urun yazdık var yazsanda olur
            foreach (var a in urunler)
            {
                Console.WriteLine(a.Adi);
                Console.WriteLine(a.Fiyati);
                Console.WriteLine(a.Açiklama);

            }

            Console.WriteLine("--------Metodlar--------");

            //encapsulation
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12, 10);
            sepetManager.Ekle2("elma", "yeşil elma", 11, 9);
            sepetManager.Ekle2("karpuz", "dbakır karpuzu", 10, 8);
            // bu şekilde yazarsan örneğin stokadedi ekle derlerse tek tek her sayfada değiştirecez




        }
    }
}


//do not repeat yourself--DRY--clean code-- Best practise

