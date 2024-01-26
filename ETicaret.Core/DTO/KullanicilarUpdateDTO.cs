using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
	public class KullanicilarUpdateDTO:BaseListDTO
	{
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool PersonelMi { get; set; }
        public string KullaniciEmail { get; set; }
        public string KullaniciResim { get; set; }
    }
}
