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
        Task<List<Adresler>> GetAllAsync();
        Task<Adresler> GetIdAsync(int id);
        Task<Adresler> AddAsync(string adresbasligi, string adres, string postaKodu, int ilKodu, int ilceKodu, int musteriId);
        Task<Adresler> UpdateAsync(int id, string adresbasligi, string adres, string postaKodu, int ilKodu, int ilceKodu);
        Task<Adresler> DeleteAsync(int id);
    }

}
