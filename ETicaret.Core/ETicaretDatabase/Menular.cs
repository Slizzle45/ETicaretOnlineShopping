using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.ETicaretDatabase
{
    public class Menular : BaseEntity
    {
        public string MenuAdi { get; set; }
        public int? UstMenuId { get; set; }
        public int MenuSirasi { get; set; }
        public string Aciklama { get; set; }
        public int ErisimAlanlariId { get; set; }
        public ICollection<Menular> AltMenu { get; set; }   
        public Menular UstMenu { get; set; }

        public ErisimAlanlari ErisimAlanlari { get; set; }
    }
}
