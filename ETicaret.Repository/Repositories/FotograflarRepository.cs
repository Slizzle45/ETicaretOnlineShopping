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
    public class FotograflarRepository : GenericRepository<Fotograflar>, IFotograflarRepository
    {
        public FotograflarRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {

        }

        public async Task<List<Fotograflar>> GetFotograflarWithUrunlerAsync()
        {
            return await _eTicaretDB.Fotograflar.Include(f => f.Urunler).ToListAsync();
        }

        public Task<Fotograflar> GetFotograflarWithUrunlerAsync(int fotograflarId)
        {
            throw new NotImplementedException();
        }
    }
}
