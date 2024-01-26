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
    public class SiparislerRespository : GenericRepository<Siparisler>, ISiparislerRepository
    {
        protected readonly AppDbContext _eTicaretDB;

        public SiparislerRespository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
            _eTicaretDB = eTicaretDB;
        }


        public async Task<List<Siparisler>> GetSiparislerMadeTodayAsync(DateTime siparisTarihi)
        {
            // return await _eTicaretDB.Siparisler.Include(m => m.EklenmeTarih).ToListAsync();
            return await GetAllQuery(s => s.EklenmeTarih == siparisTarihi).ToListAsync();
        }

        public async Task<List<Siparisler>> GetSiparislerWithMusteriAsync(Musteriler musteri)
        {
            return await GetAllQuery(m => m.MusteriId == musteri.Id).Include(m => m.Musteriler).ToListAsync();
        }

        public async Task<List<Siparisler>> GetSiparislerWithKullanicilarAsync(Kullanicilar kullanici)
        {
            return await GetAllQuery(k => k.KullaniciId == kullanici.Id).Include(m => m.Kullanicilar).ToListAsync();
        }

        public async Task<List<Siparisler>> GetSiparislerWithMusterilerAsync()
        {
            return await _eTicaretDB.Siparisler.Include(s => s.Musteriler).ToListAsync();
        }
    }
}
