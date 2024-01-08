using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.ETicaretDatabase
{
    public class YetkiErisim 
    {
        //Yetkiler ile ErişimAlanları (Sayfaları) bağlayan tablo
        //Sonsuz-Sonsuz ilişki için kurulan tablo
        public int ErisimAlaniId { get; set; }//Sayfaları
        public int YetkiId { get; set; }//yetkileri
        public string Aciklama { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        //Log
        public Yetkiler Yetkiler { get; set; }
        public ErisimAlanlari ErisimAlanlari { get; set; }
    }
}
