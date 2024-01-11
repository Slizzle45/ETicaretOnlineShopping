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
    public class MusterilerService : Service<Musteriler>, IMusterilerService
    {
        public MusterilerService(IGenericRepository<Musteriler> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

        }

        public Task<List<Musteriler>> GetMusteriWithAdresAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Musteriler> GetMusteriWithAdresAsync(int musteriID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Musteriler>> GetMusteriWithKullaniciAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Musteriler> GetMusteriWithKullaniciAsync(int musteriID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Musteriler>> GetMusteriWithSiparisAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Musteriler> GetMusteriWithSiparisAsync(int musteriID)
        {
            throw new NotImplementedException();
        }
    }
}
