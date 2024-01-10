using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.Repositories
{
    public class KategoriRepository : GenericRepository<Kategoriler>, IKategoriRepository
    {
        public KategoriRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
        }

        public Task<Kategoriler> AddAsync(string kategoriAdi, string aciklama)
        {
            throw new NotImplementedException();
        }

        public Task<Kategoriler> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Kategoriler>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Kategoriler> GetIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Kategoriler> UpdateAsync(int id, string kategoriAdi, string aciklama)
        {
            throw new NotImplementedException();
        }
    }
}
