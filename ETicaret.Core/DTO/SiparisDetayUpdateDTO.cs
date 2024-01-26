using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
    public class SiparisDetayUpdateDTO : BaseListDTO
    { 
        public int SiparisDetayId { get; set; }
        public int SiparisId { get; set; }
        public int UrunAdet { get; set; }
        public decimal BirimFiyat { get; set; }
        public string UrunId { get; set; }
    }
}
