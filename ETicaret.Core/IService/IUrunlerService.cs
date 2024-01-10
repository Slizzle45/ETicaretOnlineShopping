using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IUrunlerService : IService<Urunler>
    {
        Task<List<Urunler>> GetUrunlerWithKategoriAsync();

        Task<Urunler> GetUrunlerWithKategoriAsync(int urunlerId);

        Task<Urunler> GetUrunlerWithKategoriAsync(Urunler kategori);
    }
}
