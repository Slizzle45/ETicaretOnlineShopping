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
    public class AdreslerService : Service<Adresler>, IAdreslerService
    {
        public AdreslerService(IGenericRepository<Adresler> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public Task<Adresler> GetAdreslerWithIlceAsync(int ilceId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Adresler>> GetAdreslerWithMusteriAsync(int musteriId)
        {
            throw new NotImplementedException();
        }
    }
}
