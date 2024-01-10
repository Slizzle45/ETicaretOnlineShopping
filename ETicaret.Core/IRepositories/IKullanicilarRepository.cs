using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IRepositories
{
    public interface IKullanicilarRepository:IGenericRepository<Kullanicilar>
    {
        Task<List<Kullanicilar>> GetKullanicilarWithPersonellerAsync();
        Task<Kullanicilar> GetKullanicilarWithPersonellerAsync(int KullaniciId);

        Task<List<Kullanicilar>> GetKullanicilarWithMusterilerAsync();
        Task<Kullanicilar> GetKullanicilarWithMusterilerAsync(int KullaniciId);

        Task<List<Kullanicilar>> GetKullanicilarWithYetkilerAsync();
        Task<Kullanicilar> GetKullanicilarWithYetkilerAsync(int KullaniciId);
    }
}
