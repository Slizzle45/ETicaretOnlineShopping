using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.DTO
{
    public class GetUrunlerWithKategori
    {

        public Urunler Urunler { get; set; }
        public Kategoriler Kategoriler { get; set; }
    }
}
