using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IFotograflarService : IService<Fotograflar>
    {
        Task<List<Urunler>> GetFotograflarWithUrunlerAsync();

        Task<Urunler> GetFotograflarWithUrunlerAsync(int fotograflarId);
    }
}
