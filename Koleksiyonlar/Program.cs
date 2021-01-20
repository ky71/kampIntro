using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Ali" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            //isimler = new string[5];
            //isimler[4] = "İlker"
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            // burada isimler yeniden değişti yani 1.,2.3. ve 5. elaman boş olarak yaratıldı 4. eleman ilker oldu. yani yeni bir dizi oluştu eleman
            // array C şarpda fazla kullanılmaz çünkü arary içinde sayıarı sınırlandırıyoruz.  bunun yerine koleksiyonlar kullanılır

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Ali" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            


        }
    }
}
