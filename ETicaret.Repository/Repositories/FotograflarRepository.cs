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
    public class FotograflarRepository : GenericRepository<Fotograflar>, IFotograflarRepository
    {
        public FotograflarRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {

        }

        public async Task<string> FotografEkle(string fotografYolu, string fotografAciklamasi, byte? fotografSirasi, int urunId, bool aktifMi, DateTime eklenmeTarihi)
        {
            try
            {
                Fotograflar fotografEkle = new();
                fotografEkle.FotografYolu = fotografYolu;
                fotografEkle.FotografAciklamasi = fotografAciklamasi;
                fotografEkle.FotografSirasi = fotografSirasi;
                fotografEkle.UrunId = urunId;
                fotografEkle.AktifMi = aktifMi;
                fotografEkle.EklenmeTarih = eklenmeTarihi;
                await AddAsync(fotografEkle);

                return "İşlem başarıyla gerçekleştirildi.";
            }
            catch (Exception ex)
            {
                return $"Hata oluştu:\n{ex}";
            }
        }

        public async Task<string> FotografGuncelle(int fotografId, string fotografYolu, string fotografAciklamasi, byte? fotografSirasi, int urunId, bool aktifMi, DateTime eklenmeTarihi, DateTime guncellemeTarihi)
        {
            var fotografGuncelle = await GetByIdAsync(fotografId);

            try
            {
                fotografGuncelle.FotografYolu = fotografYolu;
                fotografGuncelle.FotografAciklamasi = fotografAciklamasi;
                fotografGuncelle.FotografSirasi = fotografSirasi;
                fotografGuncelle.UrunId = urunId;
                fotografGuncelle.AktifMi = aktifMi;
                fotografGuncelle.EklenmeTarih = eklenmeTarihi;
                fotografGuncelle.GuncellenmeTarih = guncellemeTarihi;
                
                return "İşlem başarıyla gerçekleştirildi.";
            }
            catch (Exception ex)
            {
                return $"Hata oluştu:\n{ex}";
            }
        }

        public async Task<List<Fotograflar>> FotografListesi()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<List<Fotograflar>> FotografListesi(bool aktifMi)
        {
            return await GetAllQuery(f => f.AktifMi == aktifMi).ToListAsync();
        }

        public async Task<int> FotografSayisi(int fotografId)
        {
            return await GetAllQuery(f => f.Id == fotografId).CountAsync();
        }

        public async Task<string> FotografSil(int fotografId)
        {
            var fotografSil = await GetByIdAsync(fotografId);

            try
            {
                if (fotografSil != null)
                {
                    Remove(fotografSil);
                    await _eTicaretDB.SaveChangesAsync();

                    return "İşlem başarıyla gerçekleştirildi.";
                }
                else
                {
                    return "Fotoğraf bulunamadı.";
                }
            }
            catch (Exception ex)
            {
                return $"Hata oluştu:\n{ex}";
            }
        }

    }
}
