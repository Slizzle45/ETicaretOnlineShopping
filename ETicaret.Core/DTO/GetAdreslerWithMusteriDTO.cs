using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
    public class GetAdreslerWithMusteriDTO
    {
        public string AdresBasligi { get; set; }
        public string Adres { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int PostaKodu { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }

    }
}
