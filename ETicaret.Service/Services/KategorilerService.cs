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
        public KategorilerService(IGenericRepository<Kategoriler> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public Task<List<Kategoriler>> GetKategorilerWithUrunler()
        {
            throw new NotImplementedException();
        }

        public Task<Kategoriler> GetKategorilerWithUrunler(int kategorilerId)
        {
            throw new NotImplementedException();
        }
    }
}
