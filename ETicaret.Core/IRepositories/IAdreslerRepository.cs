using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IRepositories
{
    public interface IAdreslerRepository : IGenericRepository<Adresler>
    {
        Task<List<Adresler>> AdreslerListeleAsync();
        Task<string> AdresEkleAsync(string adresbasligi, string adres, string postaKodu, int ilKodu, int ilceKodu, int musteriId);
        Task<string> AdresGuncelleAsync(int id, string adresbasligi, string adres, string postaKodu, int ilKodu, int ilceKodu);
        Task<string> AdresSilAsync(int id);
    }

}
