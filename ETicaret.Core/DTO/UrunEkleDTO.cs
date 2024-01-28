using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
    public class UrunEkleDTO:BaseDTO
    {
        public string UrunAd { get; set; }
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
       
       
    }
}
