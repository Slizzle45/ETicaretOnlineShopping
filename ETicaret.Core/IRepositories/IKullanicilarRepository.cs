using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IRepositories
{
    public interface IKullanicilarRepository:IGenericRepository<Kullanicilar>
    {
        Task<string> KullaniciEkle(string Adi, string Soyadi, string Resim, string KullaniciEmail, string KullaniciSifre, bool PersonelMi, int YetkiId, int MusteriId, int PersonelID);
        Task<string> TopluKullaniciEkle(IEnumerable<Kullanicilar> kullanicilar);

        Task<string> KullaniciGuncelle(int KullanicilarId, string Adi, string Soyadi, string Resim, string KullaniciEmail, string KullaniciSifre, bool PersonelMi,bool aktifMi,DateTime EklenmeTarihi,int YetkiId, int MusteriId, int PersonelID);

        Task<string> KullaniciSil(int KullanicilarId);
        Task<string> TopluKullaniciSil(IEnumerable<Kullanicilar> kullanicilar);

        Task<List<Kullanicilar>> KullaniciListesi();

        Task<List<Kullanicilar>> KullaniciListesi(bool aktifMi);
    }
}
