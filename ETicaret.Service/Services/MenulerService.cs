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
    public class MenulerService : Service<Menular>, IMenulerService
    {
        public MenulerService(IGenericRepository<Menular> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

        }

        public Task<List<Urunler>> GetMenulerWithUstMenuAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Urunler> GetMenulerWithUstMenuAsync(int urunlerId)
        {
            throw new NotImplementedException();
        }
    }
}
