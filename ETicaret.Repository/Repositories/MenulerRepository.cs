using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.Repositories
{
    public class MenulerRepository : GenericRepository<Menular>, IMenulerRepository
    {

        public MenulerRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
        }

        public async Task<List<Menular>> GetMenuWithUstMenuAsync()
        {
            return await _eTicaretDB.Menular.Include(m => m.UstMenu).ToListAsync();
        }

        public Task<Menular> GetMenuWithUstMenuAsync(int urunlerId)
        {
            throw new NotImplementedException();
        }
    }
}
