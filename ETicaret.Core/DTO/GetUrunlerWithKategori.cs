﻿using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
    public class GetUrunlerWithKategori
    {

        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public int UrunStok { get; set; }
        public decimal UrunFiyat { get; set; }//85
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public string KullaniciAdiSoyadi { get; set; }


    }
}
