using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
    public class SiparisDetayDTO : BaseDTO
    {
        public int SiparisDetayId { get; set; }
        public int SiparisId { get; set; }
        public int UrunId { get; set; }
        public int UrunAdet { get; set; }
        public decimal BirimFiyat { get; set; }
        public string UrunAdi { get; set; }
    }
}
