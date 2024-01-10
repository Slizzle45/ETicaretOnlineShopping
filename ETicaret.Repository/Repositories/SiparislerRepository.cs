using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.Repositories
{
    public class SiparislerRespository : GenericRepository<Siparisler>, ISiparislerRepository
    {
        public SiparislerRespository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
        }
    }
}
