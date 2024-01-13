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
    public class AdreslerRepository : GenericRepository<Adresler>, IAdreslerRepository
    {
        private readonly AppDbContext _eTicaret;
        public AdreslerRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
            _eTicaret = eTicaretDB;
        }

        public async Task<string> AdresEkleAsync(string adresbasligi, string adres, string postaKodu, int ilKodu, int ilceKodu, int musteriId)
        {
            try
            {
                Adresler adresler = new Adresler();
                adresler.AdresBasligi = adresbasligi;
                adresler.Adres = adres;
                adresler.PostaKodu = postaKodu;
                adresler.IlKodu = ilKodu;
                adresler.IlceKod = ilceKodu;
                await AddAsync(adresler);
                return "İşlem Başarılı";
            }
            catch (Exception ex)
            {
                return "İşlem sırasında hata " + ex + "oluştu";
            }
        }

        public async Task<string> AdresGuncelleAsync(int id, string adresbasligi, string adres, string postaKodu, int ilKodu, int ilceKodu)
        {
            var adresGuncelle = await GetByIdAsync(id);
            try
            {
                adresGuncelle.AdresBasligi = adresbasligi;
                adresGuncelle.Adres = adres;
                adresGuncelle.PostaKodu = postaKodu;
                adresGuncelle.IlKodu = ilKodu;
                adresGuncelle.IlceKod = ilceKodu;
                return "İşlem Başarılı";
            }
            catch (Exception ex)
            {
                return "İşlem sırasında hata " + ex + "oluştu";
            }
        }

        public async Task<List<Adresler>> AdreslerListeleAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<string> AdresSilAsync(int id)
        {
            var adresSil = await GetByIdAsync(id);
            try
            {
                if (adresSil != null)
                {
                    Remove(adresSil);
                    await _eTicaret.SaveChangesAsync();
                    return "İşlem Başarılı";
                }
                return "İşlem Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem sırasında hata " + ex + "oluştu";
            }
        }
    }
}
