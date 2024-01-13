using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
	public class KullanicilarDTO:BaseDTO
	{
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string KullaniciResim { get; set; }
        public string KullaniciEmail { get; set; }
        public string KullaniciSifre { get; set; }
        public bool PersonelMi { get; set; }
        public int YetkiId { get; set; }
        public int MusteriId { get; set; }
        public int PersonelId { get; set; }
    }
}
