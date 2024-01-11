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
    public class FotograflarService : Service<Fotograflar>, IFotograflarService
    {
        public FotograflarService(IGenericRepository<Fotograflar> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public Task<List<Urunler>> GetFotograflarWithUrunlerAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Urunler> GetFotograflarWithUrunlerAsync(int fotograflarId)
        {
            throw new NotImplementedException();
        }
    }
}
