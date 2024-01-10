using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IMenulerService : IService<Menular>
    {
        Task<List<Urunler>> GetMenulerWithUstMenuAsync();
        Task<Urunler> GetMenulerWithUstMenuAsync(int urunlerId);
    }
}
