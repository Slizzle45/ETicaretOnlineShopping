using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IRepositories
{
    public interface ISiparislerRepository : IGenericRepository<Siparisler>
    {
        //Bugün yapılan siparişler
        //Bir personelin yaptığı siparişler
        //Bir müşterinin siparişleri
        //Bir ürün için belli tarihler arasında yapılan iparişleri
    }
}
