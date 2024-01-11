using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IAdreslerService : IService<Adresler>
    {
        Task<List<Adresler>> GetAdreslerWithMusteriAsync(int musteriId);

        Task<Adresler> GetAdreslerWithIlceAsync(int ilceId);

    }
}
