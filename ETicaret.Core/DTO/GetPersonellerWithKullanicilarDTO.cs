using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
	public class GetPersonellerWithKullanicilarDTO:BaseListDTO
	{
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public bool Cinsiyet { get; set; }
        public decimal PersonelMaasi { get; set; }
        public string CalistigiFirma { get; set; }
        public string YasadigiSehir { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public bool PersonelMi { get; set; }
    }
}
