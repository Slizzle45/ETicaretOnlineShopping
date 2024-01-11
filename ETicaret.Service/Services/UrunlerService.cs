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
    public class UrunlerService : Service<Urunler>, IUrunlerService
    {
        public UrunlerService(IGenericRepository<Urunler> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

        }

        public Task<List<Urunler>> GetUrunlerWithKategoriAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Urunler> GetUrunlerWithKategoriAsync(int urunlerId)
        {
            throw new NotImplementedException();
        }

        public Task<Urunler> GetUrunlerWithKategoriAsync(Urunler kategori)
        {
            throw new NotImplementedException();
        }


    }
}
