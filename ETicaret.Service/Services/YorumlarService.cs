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
    public class YorumlarService : Service<Yorumlar>, IYorumlarService
    {
        public YorumlarService(IGenericRepository<Yorumlar> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

        }
    }
}
