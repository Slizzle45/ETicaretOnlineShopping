using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.Repositories
{
    public class UrunlerRepository : GenericRepository<Urunler>, IUrunlerRepository
    {
        public UrunlerRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
                
        }

        public async Task<List<Urunler>> GetUrunlerWithKategoriAsync()
        {
            return await _eTicaretDB.Urunler.Include(k => k.Kategoriler).ToListAsync();
            //Eager Loading=>
            //
        }

        public Task<Urunler> GetUrunlerWithKategoriAsync(int urunlerId)
        {
            throw new NotImplementedException();
        }


    }
}
