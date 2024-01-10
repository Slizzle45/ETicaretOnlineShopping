using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IRepositories
{
    public interface IYorumlarRepository : IGenericRepository<Yorumlar>
    {
        Task<IQueryable<Yorumlar>> UrunYorumlari(int urunId);
        Task<IQueryable<Yorumlar>> KullaniciYorumlari(int kullaniciId);

    }
}
