using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //string kurs1 = "yazılım geliştirici yetiştirme kampı";
            //string kurs2 = "proglamlamaya başlangıç için temel kurs";
            //string kurs2 = "Java";
            //.........
            //böyle 100 lerce ürün olabilir bunları dizilerle tanımlarız
            //aray -dizi

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", 
                "proglamlamaya başlangıç için temel kurs","Java","pyhton" };


            for (int i = 0; i < kurslar.Length; i++) //i=i+2 pythonyokkaenki durum
            {
                Console.WriteLine(kurslar[i]);
            }

            //yada diğer yazım şekli
            foreach (string kurs in kurslar) //dizileri tek tek dolaşmaya yarıyor, yazdırmaya yarıyor
            {
                Console.WriteLine(kurs);
            }

            //for (int i = 0; i <3; i++) yada //i=i+2 //3 yerine kuslar.lenght yazarak dinamik yapıyoruz
            //{
              //  Console.WriteLine(kurslar[i]);
            //}


            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
