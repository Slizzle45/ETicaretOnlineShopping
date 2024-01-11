using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
    public class GetYorumlarWithKullanicilarDTO
    {
        public string Yorum { get; set; }
        public int YorumUstId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciEmail { get; set; }

    }
}
