using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IRepositories
{
    public interface IMenulerRepository : IGenericRepository<Menular>
    {
        Task<List<Menular>> GetMenuWithUstMenuAsync();
        Task<Menular> GetMenuWithUstMenuAsync(int urunlerId);

        //SP
    }
}
