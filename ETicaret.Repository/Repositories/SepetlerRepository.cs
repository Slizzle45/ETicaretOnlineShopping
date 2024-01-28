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
    public class SepetlerRepository : GenericRepository<Sepetler>, ISepetlerRepository
    {

        public SepetlerRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
        }

        public async Task<List<Sepetler>> GetSepetlerWithKullanicilarAsync()
        {
            //return await _eTicaretDB.Sepetler.Include(k => k.kullanicilar).ToListAsync();
            throw new NotImplementedException();
        }

        public async Task<Sepetler> GetSepetlerWithKullanicilarAsync(int sepetlerId)
        {
            // return await _eTicaretDB.Sepetler.Where(k => k.Id == sepetlerId).Include(k => k.kullanicilar).FirstOrDefaultAsync();
            throw new NotImplementedException();
        }

        public async Task<Sepetler> SepettekiUrunSayisiDegistir(int urunId, int kullaniciId)
        {
            var guncelle = _eTicaretDB.Sepetler.Where(k => k.UrunId == urunId && k.KullanicilarId == kullaniciId).FirstOrDefault();

            if (guncelle != null)
            {
                int urunSayisi = guncelle.UrunAdet;
                guncelle.UrunAdet = urunSayisi + 1;
                return guncelle;
            }
            return null;
        }
    }
}
