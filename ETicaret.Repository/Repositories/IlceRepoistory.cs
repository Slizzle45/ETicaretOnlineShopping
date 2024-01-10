using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.Repositories
{
    public class IlceRepoistory : GenericRepository<Ilceler>, IIlceRepository
    {
        public IlceRepoistory(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
        }

        public Task<List<Ilceler>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Ilceler> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
