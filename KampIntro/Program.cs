using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety=tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugn = 7.45;

            if (dolarDun>dolarBugn)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugn)
            {
                Console.Write("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }



            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }        

            Console.WriteLine(kategoriEtiketi);
      

        }
    }
}
