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
    public class PersonellerRepository : GenericRepository<Personeller>, IPersonellerRepository
    {
        public PersonellerRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
        }

        public async Task<List<Personeller>> GetpersonellerWithKullanicilar()
        {
            return await _eTicaretDB.Personeller.Include(k => k.Kullanicilar).ToListAsync();
        }

        public Task<Personeller> GetPersonellerWithKullanicilar(int PersonelId)
        {
            throw new NotImplementedException();
        }
    }
}
