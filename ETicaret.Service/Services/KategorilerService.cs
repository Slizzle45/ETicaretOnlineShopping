using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using ETicaret.Core.IService;
using ETicaret.Core.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Service.Services
{
    public class KategorilerService : Service<Kategoriler>, IKategoriService
    {
        private readonly IGenericRepository<Kategoriler> _kategoryRepo;
        private readonly IUnitOfWork _unitOfWork;
        public KategorilerService(IGenericRepository<Kategoriler> kategoriRepo, IUnitOfWork unitOfWork) : base(kategoriRepo, unitOfWork)
        {
            _kategoryRepo= kategoriRepo;
            _unitOfWork= unitOfWork;

        }

        public Task<List<Kategoriler>> GetKategorilerWithUrunler()
        {
            throw new NotImplementedException();
        }

        public Task<Kategoriler> GetKategorilerWithUrunler(int kategorilerId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Kategoriler> KategoriListesi()
        {
            return _kategoryRepo.GetAll();

        }
    }
}
