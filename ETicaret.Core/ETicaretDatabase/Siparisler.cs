using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.ETicaretDatabase
{
    public class Siparisler:BaseEntity
    {   
        // Ethem
        public int ToplamUrunAdet { get; set; }
        public decimal ToplamFiyat { get; set; }
        public int MusteriId { get; set; }//++
        public ICollection<SiparisDetay> SiparisDetay { get; set; }
        public Kullanicilar Kullanicilar { get; set; }//Siparişte göre alan Personel
        public Musteriler Musteriler { get; set; }//++
    }
}
