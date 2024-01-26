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
    public class SiparislerDetayRespository : GenericRepository<SiparisDetay>, ISiparislerDetayRepository
    {
        protected readonly AppDbContext _eTicaretDB;

        public SiparislerDetayRespository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
            _eTicaretDB = eTicaretDB;
        }

        public async Task<List<SiparisDetay>> GetSiparisDetayWithSiparisAsync(int siparisID)
        {
            return await GetAllQuery(s => s.SiparisId == siparisID).Include(s => s.Siparisler).ToListAsync();
        }

        public async Task<List<SiparisDetay>> GetSiparisDetayWithUrunAsync(int urunID)
        {
            return await GetAllQuery(s => s.UrunId == urunID).Include(s => s.Urunler).ToListAsync();
        }

        public Task<List<SiparisDetay>> GetSiparislerDetayWithPieceAsync(int siparisID)
        {
            //return await GetAllQuery(s => s.SiparisId == siparisID).Sum(s => s.UrunAdet);
            throw new NotImplementedException();
        }
    }
}
