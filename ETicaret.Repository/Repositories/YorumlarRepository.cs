using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.Repositories
{
    public class YorumlarRepository : GenericRepository<Yorumlar>, IYorumlarRepository
    {
        public YorumlarRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {

        }

        public Task<IQueryable<Yorumlar>> KullaniciYorumlari(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Yorumlar>> UrunYorumlari(int urunId)
        {
            throw new NotImplementedException();
        }
    }
}
