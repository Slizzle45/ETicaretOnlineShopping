using AutoMapper;
using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using ETicaret.Core.IService;
using ETicaret.Core.IUnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Service.Services
{
    public class MenulerService : Service<Menular>, IMenulerService
    {
        private readonly IMenulerRepository _menulerRepository;
        private readonly IMapper _mapper;
        public MenulerService(IGenericRepository<Menular> repository, IUnitOfWork unitOfWork, IMenulerRepository menulerRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _menulerRepository = menulerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetMenulerWithErisimAlanDTO>> GetMenulerWithErisimAlanAsync()
        {
            var menuWithErisimAlan = await _menulerRepository.GetMenuWithErisimAlaniAsync();
            var menuErisimAlanDTO = _mapper.Map<List<GetMenulerWithErisimAlanDTO>>(menuWithErisimAlan);
            return menuErisimAlanDTO;
        }

        public async Task<GetMenulerWithErisimAlanDTO> GetMenulerWithErisimAlanAsync(int menuId)
        {
            var menuWithErisimAlan = await _menulerRepository.GetMenuWithErisimAlaniAsync(menuId);
            var menuErisimAlanDTO = _mapper.Map<GetMenulerWithErisimAlanDTO>(menuWithErisimAlan);
            return menuErisimAlanDTO;
        }

        public async Task<Menular> GetMenuWithUstMenuAsync(int menuId)
        {
            return await GetAllQuery(m => m.Id == menuId).Include(m => m.UstMenu).FirstOrDefaultAsync();
        }

        public async Task<string> MenuEkleAsync(string menuAdi, int ustMenuId, int menuSirasi, string aciklama, int erisimAlaniId, int kullaniciId)
        {
            try
            {

                Menular menu = new Menular();
                menu.MenuAdi = menuAdi;
                menu.UstMenuId = ustMenuId;
                menu.MenuSirasi = menuSirasi;
                menu.Aciklama = aciklama;
                menu.ErisimAlanlariId = erisimAlaniId;
                menu.AktifMi = false;
                menu.EklenmeTarih = DateTime.Now;
                menu.KullaniciId = kullaniciId;
                await AddAsync(menu);
                return "Ekleme başarılı";
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

        public async Task<IEnumerable<Menular>> MenuListesiAsync()
        {
            return await GetAllAsyncs();
        }

        public async Task<IEnumerable<Menular>> MenuListesiAsync(bool aktifMi)
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
