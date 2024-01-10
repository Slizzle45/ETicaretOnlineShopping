using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
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

        public Task<List<Iller>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Iller> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
