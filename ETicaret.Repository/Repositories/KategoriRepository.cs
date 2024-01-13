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
    public class KategoriRepository : GenericRepository<Kategoriler>, IKategoriRepository
    {
        private readonly AppDbContext _eTicaret;
        public KategoriRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
            _eTicaret = eTicaretDB;
        }

        public async Task<string> KategoriEkleAsync(string kategoriAdi, string aciklama)
        {
            try
            {
                Kategoriler kategoriler = new Kategoriler();
                kategoriler.KategoriAdi = kategoriAdi;
                kategoriler.Aciklama = aciklama;
                await AddAsync(kategoriler);
                return "İşlem Başarılı";
            }
            catch (Exception ex)
            {
                return "İşlem sırasında hata " + ex + "oluştu";
            }
        }

        public async Task<string> KategoriGuncelleAsync(int id, string kategoriAdi, string aciklama)
        {
            var kategoriGuncelle = await GetByIdAsync(id);
            try
            {
                kategoriGuncelle.KategoriAdi = kategoriAdi;
                kategoriGuncelle.Aciklama = aciklama;
                return "İşlem Başarılı";
            }
            catch (Exception ex)
            {
                return "İşlem sırasında hata " + ex + "oluştu";
            }
        }

        public async Task<List<Kategoriler>> KategoriListeleAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<string> KategoriSilAsync(int id)
        {
            try
            {
                var kategoriPasifEt = await GetByIdAsync(id);
                kategoriPasifEt.AktifMi = false;
                return "İşlem Başarılı";
            }
            catch (Exception ex)
            {
                return "İşlem sırasında hata " + ex + "oluştu";
            }
        }
    }
}
