using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
    public class SiparislerUpdateDTO : BaseListDTO
    {
        public int ToplamUrunAdet { get; set; }
        public decimal ToplamFiyat { get; set; }
        public string MusteriId { get; set; }
        public string KullaniciId { get; set; }
    }
}
