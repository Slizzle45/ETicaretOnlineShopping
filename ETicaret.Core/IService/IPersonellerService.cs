﻿using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IPersonellerService:IService<Personeller>
    {
        Task<List<GetPersonellerWithKullanicilarDTO>> GetPersonellerWithKullanicilarAsync();
        Task<GetPersonellerWithKullanicilarDTO> GetPersonellerWithKullanicilarAsync(int persoenllerId);
        Task<Personeller> GetPersonellerWithKullanicilarAsync(Personeller personel);


    }
}
