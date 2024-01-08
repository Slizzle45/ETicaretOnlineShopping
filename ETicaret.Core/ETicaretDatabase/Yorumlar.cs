using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.ETicaretDatabase
{
    public class Yorumlar : BaseEntity
    {
        public string Yorum { get; set; }
        public int YorumUstId { get; set; }
        public int UrunId { get; set; }
        public Urunler Urunler { get; set; }
        public Kullanicilar Kullanicilar { get; set; }

        //İsa 8 Ocak 2024 09:59
    }
}
