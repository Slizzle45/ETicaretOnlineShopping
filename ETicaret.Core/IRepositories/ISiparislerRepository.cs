using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IRepositories
{
    public interface ISiparislerRepository : IGenericRepository<Siparisler>
    {
        // Eklenme tarihine göre siparişleri listeler
        Task<List<Siparisler>> GetSiparislerMadeTodayAsync(DateTime siparisTarihi);
        // Siparişi gerçekleştiren Personele göre listeler
        Task<List<Siparisler>> GetSiparislerWithKullanicilarAsync(Kullanicilar kullaniciID);
        // Siparişi gerçekleştiren müşterilere göre listeler
        Task<List<Siparisler>> GetSiparislerWithMusteriAsync(Musteriler musteriID);
        Task<List<Siparisler>> GetSiparislerWithMusterilerAsync();
    }
}
