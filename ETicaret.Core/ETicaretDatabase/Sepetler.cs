using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.ETicaretDatabase
{
    public class Sepetler 
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public int UrunAdet { get; set; }
        public decimal UrunFiyati { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public int KullanicilarId { get; set; }
        public int MusteriId { get; set; }

        //public string OdemeSekli { get; set; }
        //public decimal ToplamOdeme { get; set; }
        //public string KargoAdresi { get; set; }
        //public string KartNumarasi { get; set; }
        //public string SiparisDurumu { get; set; }
        //public string MusteriNot { get; set; }
        //public ICollection<Urunler> Urunler { get; set; }
        //public ICollection<Siparisler> Siparisler { get; set; }
        //public Kullanicilar kullanicilar { get; set; }

    }
}
