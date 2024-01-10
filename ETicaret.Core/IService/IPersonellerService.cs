using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IPersonellerService:IService<Personeller>
    {
        Task<List<Personeller>> GetPersonellerWithKullanicilar();
        Task<Personeller>GetPersonellerWithKullanicilar(Personeller kullanici);
    }
}
