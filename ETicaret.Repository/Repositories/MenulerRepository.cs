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
    public class MenulerRepository : GenericRepository<Menular>, IMenulerRepository
    {

        public MenulerRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
        }

        public async Task<List<Menular>> GetMenuWithErisimAlaniAsync()
        {
            return await _eTicaretDB.Menular.Include(m => m.ErisimAlanlari).ToListAsync();
        }

        public async Task<Menular> GetMenuWithErisimAlaniAsync(int menuId)
        {
            return await GetAllQuery(m => m.Id == menuId).Include(m => m.ErisimAlanlari).FirstOrDefaultAsync();
        }

        public async Task<List<Menular>> GetMenuWithUstMenuAsync()
        {
            return await _eTicaretDB.Menular.Include(m => m.UstMenu).ToListAsync();
        }
        public async Task<Menular> GetMenuWithUstMenuAsync(int menuId)
        {
            return await GetAllQuery(m => m.Id == menuId).Include(m => m.UstMenu).FirstOrDefaultAsync();
        }

        public async Task<string> MenuEkleAsync(string menuAdi, int ustMenuId, int menuSirasi, string aciklama, int erisimAlaniId, bool aktifMi, DateTime eklemeTarihi, DateTime guncellemeTarihi, int kullaniciId)
        {
            try
            {

                Menular menu = new Menular();
                menu.MenuAdi = menuAdi;
                menu.UstMenuId = ustMenuId;
                menu.MenuSirasi = menuSirasi;
                menu.Aciklama = aciklama;
                menu.ErisimAlanlariId = erisimAlaniId;
                menu.AktifMi = aktifMi;
                menu.EklenmeTarih = eklemeTarihi;
                menu.GuncellenmeTarih = guncellemeTarihi;
                menu.KullaniciId = kullaniciId;
                await AddAsync(menu); return "Ekleme başarılı";
            }
            catch (Exception)
            {
                return "Ekleme esnasında hata oluştu";
            };
        }
        public async Task<string> MenuGuncelleAsync(int menuId, string menuAdi, int ustMenuId, int menuSirasi, string aciklama, int erisimAlaniId, bool aktifMi, DateTime eklemeTarihi, DateTime guncellemeTarihi, int kullaniciId)
        {
            var menuBul = await GetByIdAsync(menuId);
            try
            {
                menuBul.MenuAdi = menuAdi;
                menuBul.UstMenuId = ustMenuId;
                menuBul.MenuSirasi = menuSirasi;
                menuBul.Aciklama = aciklama;
                menuBul.ErisimAlanlariId = erisimAlaniId;
                menuBul.AktifMi = aktifMi;
                menuBul.EklenmeTarih = eklemeTarihi;
                menuBul.GuncellenmeTarih = guncellemeTarihi;
                menuBul.KullaniciId = kullaniciId;
                return "Güncelleme başarılı";
            }
            catch (Exception)
            {
                return "Güncelleme esnasında hata oluştu";
            }
        }
        public async Task<List<Menular>> MenuListesiAsync()
        {
            return await GetAll().ToListAsync();
        }
        public async Task<List<Menular>> MenuListesiAsync(bool aktifMi)
        {
            return await GetAllQuery(m => m.AktifMi == aktifMi).ToListAsync();
        }
        public async Task<string> MenuSilAsync(int menuId)
        {
            var menuSil = await GetByIdAsync(menuId);
            try
            {
                menuSil.AktifMi = false;
                return "Silme başarılı";
            }
            catch (Exception)
            {
                return "Silme esnasında hata oluştu";
            }
        }
    }
}
