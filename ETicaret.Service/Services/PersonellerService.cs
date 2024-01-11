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
	public class PersonellerService : Service<Personeller>, IPersonellerService
	{
		public PersonellerService(IGenericRepository<Personeller> Repository, IUnitOfWork unitOfWork) : base(Repository, unitOfWork)
		{
		}

		public async Task<List<Personeller>> GetPersonellerWithKullanicilar()
		{
			throw new NotImplementedException();
		}

		public Task<Personeller> GetPersonellerWithKullanicilar(Personeller kullanici)
		{
			throw new NotImplementedException();
		}
	}
}
