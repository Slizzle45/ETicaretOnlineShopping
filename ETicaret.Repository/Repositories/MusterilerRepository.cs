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
    public class MusterilerRepository : GenericRepository<Musteriler>, IMusterilerRepository
    {
        public MusterilerRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {

        }

        public async Task<List<Musteriler>> GetMusteriWithSiparisAsync()
        {
            return await _eTicaretDB.Musteriler.Include(m => m.Siparisler).ToListAsync();
        }

        public Task<Musteriler> GetMusteriWithSiparisAsync(int musteriID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Musteriler>> GetMusteriWithAdresAsync()
        {
            return await _eTicaretDB.Musteriler.Include(m => m.Adresler).ToListAsync();
        }

        public Task<Musteriler> GetMusteriWithAdresAsync(int musteriID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Musteriler>> GetMusteriWithKullaniciAsync()
        {
            return await _eTicaretDB.Musteriler.Include(m => m.Kullanicilar).ToListAsync();
        }

        public Task<Musteriler> GetMusteriWithKullaniciAsync(int musteriID)
        {
            throw new NotImplementedException();
        }
    }
}
