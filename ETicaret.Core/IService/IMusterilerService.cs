using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IMusterilerService : IService<Musteriler>
    {
        Task<IEnumerable<Musteriler>> GetMusteriWithSiparisAsync();
        Task<Musteriler> GetMusteriWithSiparisAsync(int musteriID);
        Task<IEnumerable<Musteriler>> GetMusteriWithAdresAsync();
        Task<Musteriler> GetMusteriWithAdresAsync(int musteriID);
        Task<IEnumerable<Musteriler>> GetMusteriWithKullaniciAsync();
        Task<Musteriler> GetMusteriWithKullaniciAsync(int musteriID);
        Task<string> MusteriEkleAsync(string adi, string soyadi, string cinsiyet, string telefon, string meslek, DateTime dogumTarihi, bool aktifMi, DateTime eklenmeTarihi, DateTime guncellenmeTarihi, int kullaniciId);
        Task<string> MusteriGuncelleAsync(int musteriId,string adi, string soyadi, string cinsiyet, string telefon, string meslek, DateTime dogumTarihi, bool aktifMi, DateTime eklenmeTarihi, DateTime guncellenmeTarihi, int kullaniciId);
        Task<string> MusteriSilAsync(int musteriId);
        Task<IEnumerable<Musteriler>> MusteriListesiAsync();
        Task<IEnumerable<Musteriler>> MusteriListesiAsync(bool aktifMi);

    }
}
