using ETicaret.Core.DTO;
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
        //readonly IKategoriRepository _kategoriRepository;
        readonly IUrunlerRepository _urunlerRepository;

        public UrunlerService(IGenericRepository<Urunler> repository, IUnitOfWork unitOfWork, IUrunlerRepository urunlerRepository) : base(repository, unitOfWork)
        {
            //_kategoriRepository = kategoriRepository;
            _urunlerRepository= urunlerRepository;
        }

        public Task<List<Urunler>> GetUrunlerWithKategoriAsync()
        {
            return _urunlerRepository.GetUrunlerWithKategoriAsync();

        }

        public Task<Urunler> GetUrunlerWithKategoriAsync(int urunlerId)
        {
            throw new NotImplementedException();
        }

        public Task<Urunler> GetUrunlerWithKategoriAsync(Urunler kategori)
        {
            throw new NotImplementedException();
        }

        public Task<GetUrunlerWithKategoriDTO> GetUrunlerKategoriler()
        {
            throw new NotImplementedException();
        }

    }
}
