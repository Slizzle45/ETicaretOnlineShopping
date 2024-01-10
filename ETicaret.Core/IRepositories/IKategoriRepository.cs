using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IRepositories
{
    public interface IKategoriRepository : IGenericRepository<Kategoriler>
    {
        Task<List<Kategoriler>> GetAllAsync();
        Task<Kategoriler> GetIdAsync(int id);
        Task<Kategoriler> AddAsync(string kategoriAdi, string aciklama);
        Task<Kategoriler> UpdateAsync(int id, string kategoriAdi, string aciklama);
        Task<Kategoriler> DeleteAsync(int id);
    }
}
