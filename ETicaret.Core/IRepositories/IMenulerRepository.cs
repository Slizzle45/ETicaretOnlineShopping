﻿using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IRepositories
{
    public interface IMenulerRepository : IGenericRepository<Menular>
    {
        Task<List<Menular>> GetMenuWithErisimAlaniAsync();
        Task<Menular> GetMenuWithErisimAlaniAsync(int menuId);
        Task<List<Menular>> GetMenuWithUstMenuAsync();
        Task<Menular> GetMenuWithUstMenuAsync(int menuId);
        Task<string> MenuEkleAsync(string menuAdi, int ustMenuId, int menuSirasi, string aciklama, int erisimAlaniId, bool aktifMi, DateTime eklemeTarihi, DateTime guncellemeTarihi, int kullaniciId);
        Task<string> MenuGuncelleAsync(int menuId, string menuAdi, int ustMenuId, int menuSirasi, string aciklama, int erisimAlaniId, bool aktifMi, DateTime eklemeTarihi, DateTime guncellemeTarihi, int kullaniciId);
        Task<string> MenuSilAsync(int menuId);
        Task<List<Menular>> MenuListesiAsync();
        Task<List<Menular>> MenuListesiAsync(bool aktifMi);

        //SP
    }
}
