﻿using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IMusterilerService : IService<Musteriler>
    {
        Task<List<Musteriler>> GetMusteriWithSiparisAsync();
        Task<Musteriler> GetMusteriWithSiparisAsync(int musteriID);
        Task<List<Musteriler>> GetMusteriWithAdresAsync();
        Task<Musteriler> GetMusteriWithAdresAsync(int musteriID);
        Task<List<Musteriler>> GetMusteriWithKullaniciAsync();
        Task<Musteriler> GetMusteriWithKullaniciAsync(int musteriID);

    }
}