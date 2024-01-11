using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.DTO
{
    public class KategorilerDTO
    {
        public int Id { get; set; }
        public bool AktifMi { get; set; }
        public DateTime EklenmeTarih { get; set; }
        public DateTime? GuncellenmeTarih { get; set; }
        public int? KullaniciId { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
