using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
	public class GetKullanicilarWithPersonellerDTO:BaseListDTO
	{
        public Kullanicilar kullanicilar { get; set; }

        public string  PersonelAdi { get; set; }

        public string PersonelSoyadi { get; set; }

        public decimal PersonelMaasi { get; set; }

        public string PersonelCalistigiFirma { get; set; }

        public string PersonelYasadigiSehir{ get; set; }


    }
}
