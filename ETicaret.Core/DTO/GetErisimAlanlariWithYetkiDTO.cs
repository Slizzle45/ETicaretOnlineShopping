using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DTO
{
    public class GetErisimAlanlariWithYetkiDTO
    {
        public int ErisimAlaniId { get; set; }
        public int YetkiId { get; set; }
        public string YetkiAdi { get; set; }
        public string ControllerAdi { get; set; }
        public string ViewAdi { get; set; }

    }
}
