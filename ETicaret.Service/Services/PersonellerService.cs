using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using ETicaret.Core.IService;
using ETicaret.Core.IUnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Service.Services
{
	public class PersonellerService : Service<Personeller>, IPersonellerService
	{
		public PersonellerService(IGenericRepository<Personeller> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
		{
		}

		public async Task<string> PersonelEkle(string Adi, string Soyadi, string cinsiyet, decimal maasi, DateTime MaasOdemeTarihi, bool MedeniHali, string CalistigiFirma, string hakkinda, string yasadigiSehir, int personelBilgileriId, int kullaniciId)
		{
			try
			{
				Personeller personelEkle = new Personeller();
				personelEkle.PersonelAdi = Adi;
				personelEkle.PersonelSoyadi = Soyadi;
				personelEkle.Cinsiyet = cinsiyet;
				personelEkle.PersonelMaasi = maasi;
				personelEkle.MaasOdemeTarihi = MaasOdemeTarihi;
				personelEkle.MedeniHali = MedeniHali;
				personelEkle.CalistigiFirma = CalistigiFirma;
				personelEkle.PersonelHakkinda = hakkinda;
				personelEkle.YasadigiSehir = yasadigiSehir;
				personelEkle.PersonelKullaniciBilgileriId = personelBilgileriId;
				personelEkle.kullaniciId = kullaniciId;
			    await AddAsync(personelEkle);
				return "Ekleme başarılı";
			}
			catch (Exception)
			{

				return "Ekleme işlem esnasında hata oluştu";
			}

		}

		public async Task<string> PersonelGuncelle(int personellerId, string Adi, string Soyadi, string cinsiyet, decimal maasi, DateTime MaasOdemeTarihi, bool MedeniHali, string CalistigiFirma, string hakkinda, string yasadigiSehir, bool aktifMi, DateTime eklenmeTarihi, int personelBilgileriId, int kullaniciId)
		{
			var personelGuncelle = await GetByIdAsync(personellerId);
			try
			{
				personelGuncelle.PersonelAdi = Adi;
				personelGuncelle.PersonelSoyadi = Soyadi;
				personelGuncelle.Cinsiyet = cinsiyet;
				personelGuncelle.PersonelMaasi = maasi;
				personelGuncelle.MaasOdemeTarihi = MaasOdemeTarihi;
				personelGuncelle.GuncellenmeTarih = DateTime.Now;
				personelGuncelle.MedeniHali = MedeniHali;
				personelGuncelle.CalistigiFirma = CalistigiFirma;
				personelGuncelle.PersonelHakkinda = hakkinda;
				personelGuncelle.YasadigiSehir = yasadigiSehir;
				personelGuncelle.AktifMi = aktifMi;
				personelGuncelle.EklenmeTarih = eklenmeTarihi;
				personelGuncelle.PersonelKullaniciBilgileriId = personelBilgileriId;
				personelGuncelle.kullaniciId = kullaniciId;

				return  "Güncelleme başarılı";
			}
			catch (Exception)
			{

				return "Güncelleme işlemi esnasında hata oluştu";
			}
		}

		public Task<List<Personeller>> PersoneListesi(bool aktifMi)
		{
			var query = GetAllQuery(p => p.AktifMi == aktifMi);
			var sonuc = query.ToListAsync();
			return sonuc;
		}

		public async Task<List<Personeller>> PersonelListesi()
		{
			var sonuc = await GetAllAsyncs();
			return sonuc.ToList();
		}

		public async Task<string> PersonelSil(int personellerId)
		{
			var personelSil=await GetByIdAsync(personellerId);
			try
			{
				if (personelSil!=null)
				{
			      await RemoveAsync(personelSil);
					return "Silme işlemi başarılı";
				}
				else
				{
					return "Personel bulunamadı";
				}
			}
			catch (Exception)
			{

				return "Silme işlmei esnasında hata oluştu";
			}
		}

		public async Task<string> TopluPersonelEkle(IEnumerable<Personeller> personeller)
		{
			try
			{
				await AddRangeAsync(personeller);
				return "Toplu Ekleme işlemi başarılı";
			}
			catch (Exception)
			{

				return "Toplu ekleme işlmei esnasında hata oluştu";
			}
		}

		public async Task<string> TopluPersonelSil(IEnumerable<Personeller> personeller)
		{
			try
			{
				await RemoveRangeAsync(personeller);
				return "Toplu silme işlemi başarılı";
			}
			catch (Exception)
			{

				return "Toplu silme işlmeinde hata oluştu";
			}
		}
	}
}
