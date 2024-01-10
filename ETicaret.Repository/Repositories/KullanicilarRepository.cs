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
    public class KullanicilarRepository : GenericRepository<Kullanicilar>, IKullanicilarRepository
    {
        public KullanicilarRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
        }

        public async Task<List<Kullanicilar>> GetKullanicilarWithMusterilerAsync()
        {
            return await _eTicaretDB.Kullanicilar.Include(k => k.Musteriler).ToListAsync();
        }

        public Task<Kullanicilar> GetKullanicilarWithMusterilerAsync(int KullaniciId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Kullanicilar>> GetKullanicilarWithPersonellerAsync()
        {
            return await _eTicaretDB.Kullanicilar.Include(k => k.Personeller).ToListAsync();
        }

        public async Task<Kullanicilar> GetKullanicilarWithPersonellerAsync(int KullaniciId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Kullanicilar>> GetKullanicilarWithYetkilerAsync()
        {
            return await _eTicaretDB.Kullanicilar.Include(k => k.Yetkiler).ToListAsync();
        }

        public Task<Kullanicilar> GetKullanicilarWithYetkilerAsync(int KullaniciId)
        {
            throw new NotImplementedException();
        }
    }
}
