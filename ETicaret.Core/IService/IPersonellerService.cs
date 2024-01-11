using ETicaret.Core.ETicaretDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IPersonellerService:IService<Personeller>
    {
        Task<string> PersonelEkle(string Adi, string Soyadi, string cinsiyet, decimal maasi, DateTime MaasOdemeTarihi, bool MedeniHali, string CalistigiFirma, string hakkinda, string yasadigiSehir,int personelBilgileriId,int kullaniciId);
        Task<string> TopluPersonelEkle(IEnumerable<Personeller> personeller);

        Task<string> PersonelGuncelle(int personellerId, string Adi, string Soyadi, string cinsiyet, decimal maasi, DateTime MaasOdemeTarihi, bool MedeniHali, string CalistigiFirma, string hakkinda, string yasadigiSehir,bool aktifMi,DateTime eklenmeTarihi ,int personelBilgileriId, int kullaniciId);

        Task<string> PersonelSil(int personellerId);
        Task<string> TopluPersonelSil(IEnumerable<Personeller> personeller);

        Task<List<Personeller>> PersonelListesi();
        Task<List<Personeller>> PersoneListesi(bool aktifMi);


    }
}
