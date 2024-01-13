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
    public class ILRepository : GenericRepository<Iller>, IilRepository
    {
        public ILRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
        }

        public async Task<List<Iller>> GetIllerWithIlceler(int ilId)
        {
            return await _eTicaretDB.Iller.Include(k => k.Ilceler).ToListAsync();
        }

        public async Task<List<Iller>> IllerListele()
        {
            return await GetAll().ToListAsync();
        }
    }
}
