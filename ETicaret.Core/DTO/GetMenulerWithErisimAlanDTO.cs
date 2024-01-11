using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
    public class GetMenulerWithErisimAlanDTO
    {
        public string MenuAdi { get; set; }
        public int? UstMenuId { get; set; }
        public int MenuSirasi { get; set; }
        public string Aciklama { get; set; }
        public string ControllerAdi { get; set; }
        public string ViewAdi { get; set; }
    }
}
