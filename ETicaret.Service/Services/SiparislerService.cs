using AutoMapper;
using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using ETicaret.Core.IService;
using ETicaret.Core.IUnitOfWork;
using ETicaret.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Service.Services
{
    public class SiparislerService : Service<Siparisler>, ISiparislerService
    {
        readonly ISiparislerRepository _siparislerRepository;
        readonly IMapper _mapper;

        public SiparislerService(IGenericRepository<Siparisler> repository, IUnitOfWork unitOfWork, ISiparislerRepository siparislerRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _siparislerRepository = siparislerRepository;
            _mapper = mapper;
        }

        public async Task<List<Siparisler>> GetSiparislerMadeTodayAsync(DateTime siparisTarihi)
        {
            return await GetAllQuery(s => s.EklenmeTarih == siparisTarihi).ToListAsync();
        }

        public async Task<List<Siparisler>> GetSiparislerWithKullanicilarAsync(Kullanicilar kullanici)
        {
            return await GetAllQuery(k => k.KullaniciId == kullanici.Id).Include(m => m.Kullanicilar).ToListAsync();
        }

        public async Task<List<Siparisler>> GetSiparislerWithMusteriAsync(Musteriler musteri)
        {
            return await GetAllQuery(m => m.MusteriId == musteri.Id).Include(m => m.Musteriler).ToListAsync();
        }

        public async Task<List<GetSiparislerWithMusterilerDTO>> GetSiparislerWithMusterilerAsync()
        {
            var siparisVeMusteriList = await _siparislerRepository.GetSiparislerWithMusterilerAsync();
            var siparisVeMusteriDTO = _mapper.Map<List<GetSiparislerWithMusterilerDTO>>(siparisVeMusteriList);
            return siparisVeMusteriDTO;
        }
    }
}
