using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IKullanicilarService:IService<Kullanicilar>
    {
        Task<List<Kullanicilar>> GetKullanicilarWithPersoneller();
        Task<Kullanicilar> GetKullanicilarWithPersoneller(Kullanicilar personel);

        Task<List<Kullanicilar>> GetKullanicilarWithMusteriler();
        Task<Kullanicilar>GetKullanicilarWithMusteriler(Kullanicilar musteri);

        Task<List<Kullanicilar>> GetKullanicilarWithYetkiler();
        Task<Kullanicilar>GetKullanicilarWithYetkiler(Kullanicilar yetk);
    }
}
