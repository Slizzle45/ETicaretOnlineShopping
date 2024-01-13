using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IRepositories
{
    public interface IPersonellerRepository:IGenericRepository<Personeller>
    {
        Task<string> PersonelEkle(string PersonelAdi, string PersonelSoyadi, string Cinsiyet, decimal Maas, DateTime MaasOdemeTarih, bool MedeniHali, string CalistigiFirma, string Hakkinda, string yasadigiSehir, int personelBilgiId,int kullaniciId);
        Task<string> TopluPersonelEkle(IEnumerable<Personeller> personeller);

        Task<string> PersonelGuncelle(int PersonellerId, string PersonelAdi, string PersonelSoyadi, string Cinsiyet, decimal Maas, DateTime MaasOdemeTarih, bool MedeniHali, string CalistigiFirma, string Hakkinda, string yasadigiSehir, bool aktifMi, DateTime EklenmeTarihi, int personelBilgiId,int kullaniciId);

        Task<string> PersonelSil(int PersonellerId);
        Task<string> TopluPersonelSil(IEnumerable<Personeller> personeller);    

        Task<List<Personeller>> Personelistesi();

        Task<List<Personeller>> PersonelListesi(bool aktifMi);
    }
}
