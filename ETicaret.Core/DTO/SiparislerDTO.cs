using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
    public class SiparislerDTO : BaseDTO
    {
        public int ToplamUrunAdet { get; set; }
        public decimal ToplamFiyat { get; set; }
        public string MusteriAdi { get; set; }
        public string KullaniciAdi { get; set; }
    }
}
