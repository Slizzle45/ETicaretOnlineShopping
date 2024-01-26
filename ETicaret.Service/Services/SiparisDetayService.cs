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
    public class SiparisDetayService : Service<SiparisDetay>, ISiparislerDetayService
    {
        readonly ISiparislerDetayRepository _siparisDetayRepository;

        public SiparisDetayService(IGenericRepository<SiparisDetay> repository, IUnitOfWork unitOfWork, ISiparislerDetayRepository siparisDetayRepository) : base(repository, unitOfWork)
        {
            _siparisDetayRepository = siparisDetayRepository;
        }

        public async Task<List<SiparisDetay>> GetSiparisDetayWithSiparisAsync(int siparisID)
        {
            return await GetAllQuery(s => s.SiparisId == siparisID).Include(s => s.Siparisler).ToListAsync();
        }

        public async Task<List<SiparisDetay>> GetSiparisDetayWithUrunAsync(int urunID)
        {
            return await GetAllQuery(s => s.UrunId == urunID).Include(s => s.Urunler).ToListAsync();
        }

        public Task<List<SiparisDetay>> GetSiparislerDetayWithPieceAsync(int siparisID)
        {
            throw new NotImplementedException();
        }
    }
}
