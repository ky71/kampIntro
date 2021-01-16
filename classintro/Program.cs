using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";

            // ancak tanımlamada birden fazla bilgi içerebilir bu nedenle class oluşturuyoruz en altta
            // Kurs yeni bir string gibi bi tanım yaptık
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "<python";
            kurs3.Eğitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Eğitmen = "hasan asaas";
            kurs4.IzlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " : " + kurs.Eğitmen);
            }

            

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);




        }
    }

    class Kurs
    {
        public string KursAdi { get; set; } //prop dan çıkıyo bu kalıp
        public string Eğitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }


}
