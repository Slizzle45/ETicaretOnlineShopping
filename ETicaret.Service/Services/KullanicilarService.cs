using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using ETicaret.Core.IService;
using ETicaret.Core.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Service.Services
{
	public class KullanicilarService : Service<Kullanicilar>, IKullanicilarService
	{
		public KullanicilarService(IGenericRepository<Kullanicilar> Repository, IUnitOfWork unitOfWork) : base(Repository, unitOfWork)
		{
		}

        public Task<List<Kullanicilar>> GetKullanicilarWithMusteriler()
        {
            throw new NotImplementedException();
        }

        public Task<Kullanicilar> GetKullanicilarWithMusteriler(Kullanicilar musteri)
        {
            throw new NotImplementedException();
        }

        public Task<List<Kullanicilar>> GetKullanicilarWithPersoneller()
        {
            throw new NotImplementedException();
        }

        public Task<Kullanicilar> GetKullanicilarWithPersoneller(Kullanicilar personel)
        {
            throw new NotImplementedException();
        }

        public Task<List<Kullanicilar>> GetKullanicilarWithYetkiler()
        {
            throw new NotImplementedException();
        }

        public Task<Kullanicilar> GetKullanicilarWithYetkiler(Kullanicilar yetk)
        {
            throw new NotImplementedException();
        }
    }
}
