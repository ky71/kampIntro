using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class Urun
    {
        //property-özellik
        public int Id { get; set; } //datayı diğerlerinden ayırt etmek için kullanılan bir şey 
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Açiklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
