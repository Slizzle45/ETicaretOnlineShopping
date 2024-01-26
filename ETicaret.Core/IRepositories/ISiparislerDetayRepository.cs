﻿using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IRepositories
{
    public interface ISiparislerDetayRepository : IGenericRepository<SiparisDetay>
    {
        Task<List<SiparisDetay>> GetSiparisDetayWithUrunAsync(int urunID);
        Task<List<SiparisDetay>> GetSiparisDetayWithSiparisAsync(int siparisID);
        Task<List<SiparisDetay>> GetSiparislerDetayWithPieceAsync(int siparisID);
    }
}
