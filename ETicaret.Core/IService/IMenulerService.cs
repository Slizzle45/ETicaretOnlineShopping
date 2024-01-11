using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IMenulerService : IService<Menular>
    {
        Task<IEnumerable<Menular>> GetMenulerWithUstMenuAsync();
        Task<Menular> GetMenuWithUstMenuAsync(int menuId);
        Task<string> MenuEkleAsync(string menuAdi, int ustMenuId, int menuSirasi, string aciklama, int erisimAlaniId, bool aktifMi, DateTime eklemeTarihi, DateTime guncellemeTarihi, int kullaniciId);
        Task<string> MenuGuncelleAsync(int menuId, string menuAdi, int ustMenuId, int menuSirasi, string aciklama, int erisimAlaniId, bool aktifMi, DateTime eklemeTarihi, DateTime guncellemeTarihi, int kullaniciId);
        Task<string> MenuSilAsync(int menuId); Task<IEnumerable<Menular>> MenuListesiAsync();
        Task<IEnumerable<Menular>> MenuListesiAsync(bool aktifMi);
    }
}
