using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IKullanicilarService:IService<Kullanicilar>
    {
        Task<string> KullaniciEkle(string Adi, string Soyadi, string Resim, string Email, string sifre, bool personelMi, int yetkiId,int PersonelId,int personelId);
        Task<string> TopluKullaniciEkle(IEnumerable<Kullanicilar> kullanicilar);

        Task<string> KullaniciGuncelle(int kullanicilarId, string Adi, string Soyadi, string Resim, string Email, string sifre, bool personelMi, bool aktifMi, DateTime eklenmeTarihi, int yetkiId, int MusteriId, int personelId);

        Task<string> KullaniciSil(int kullanicilarId);
        Task<string> TopluKullaniciSil(IEnumerable<Kullanicilar> kullanicilar);

        Task<List<Kullanicilar>> KullaniciListesi();
        Task<List<Kullanicilar>> KullaniciListesi(bool aktifMi);
    }
}
