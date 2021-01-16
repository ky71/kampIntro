using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention E büyük yazıldı
        public void Ekle(Urun aaaaa)
        {
            Console.WriteLine(" Tebrikler.Sepete eklendi : " + aaaaa.Adi);
            Console.WriteLine(" Tebrikler.Sepete eklendi : " + aaaaa.Fiyati);


        }

        public void Ekle2(string urunAdi, string Açiklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine(" Tebrikler.Sepete eklendi : " + urunAdi);
        }
        

        

    }
}
