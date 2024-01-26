using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface ISiparislerService : IService<Siparisler>
    {
        // Eklenme tarihine göre siparişleri listeler
        Task<List<Siparisler>> GetSiparislerMadeTodayAsync(DateTime siparisTarihi);
        // Siparişi gerçekleştiren Personele göre listeler
        Task<List<Siparisler>> GetSiparislerWithKullanicilarAsync(Kullanicilar kullanici);
        // Siparişi gerçekleştiren müşterilere göre listeler
        Task<List<Siparisler>> GetSiparislerWithMusteriAsync(Musteriler musteri);
        Task<List<GetSiparislerWithMusterilerDTO>> GetSiparislerWithMusterilerAsync();
    }
}
