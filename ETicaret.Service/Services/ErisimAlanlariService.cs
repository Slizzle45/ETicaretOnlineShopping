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
    public class ErisimAlanlariService : Service<ErisimAlanlari>, IErisimAlanlariService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<ErisimAlanlari> _repository;
        private readonly IGenericRepository<YetkiErisim> _yetkiErisimRepository;

        public ErisimAlanlariService(IGenericRepository<ErisimAlanlari> repository, IUnitOfWork unitOfWork, IGenericRepository<YetkiErisim> yetkiErisimRepository) : base(repository, unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _yetkiErisimRepository = yetkiErisimRepository;
        }

        public async Task<List<ErisimAlanlari>> GetErisimAlanlariWithYetkiIdAsync(int yetkiId)
        {
            var yetkiErisimler = await _yetkiErisimRepository.GetAllQuery(y => y.YetkiId == yetkiId)
                .Include(z => z.ErisimAlanlari)
                .Select(k => k.ErisimAlanlari)
                .ToListAsync();

            return yetkiErisimler;
        }
    }
}
