using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using ETicaret.Core.IService;
using ETicaret.Core.IUnitOfWork;
using ETicaret.Repository.UntiOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Service.Services
{
	public class KullanicilarService : Service<Kullanicilar>, IKullanicilarService
	{
		public KullanicilarService(IGenericRepository<Kullanicilar> Repository, IUnitOfWork unitOfWork) : base(Repository, unitOfWork)
		{
		}

		public async Task<string> KullaniciEkle(string Adi, string Soyadi, string Resim, string Email, string sifre, bool personelMi, int yetkiId, int MusteriId, int personelId)
		{
			try
			{
				Kullanicilar kullaniciEkle = new Kullanicilar();
				kullaniciEkle.Adi = Adi;
				kullaniciEkle.Soyadi = Soyadi;
				kullaniciEkle.KullaniciResim = Resim;
				kullaniciEkle.KullaniciEmail = Email;
				kullaniciEkle.KullaniciSifre = sifre;
				kullaniciEkle.PersonelMi = personelMi;
				kullaniciEkle.GuncellenmeTarih = DateTime.Now;
				kullaniciEkle.YetkiId = yetkiId;
				kullaniciEkle.MusteriId=MusteriId;
				kullaniciEkle.PersonelId=personelId;
				await AddAsync(kullaniciEkle);
				return "Kullanıcı eklendi";
			}
			catch (Exception)
			{

				return "Kullanıcı ekleme esnasında hata oluştu";
			}

		}

		public async Task<string> KullaniciGuncelle(int kullanicilarId, string Adi, string Soyadi, string Resim, string Email, string sifre, bool personelMi, bool aktifMi, DateTime eklenmeTarihi, int yetkiId, int MusteriId, int personelId)
		{
			var kullaniciGuncelle =await GetByIdAsync(kullanicilarId);
			try
			{
				kullaniciGuncelle.Adi = Adi;
				kullaniciGuncelle.Soyadi = Soyadi;
				kullaniciGuncelle.KullaniciResim = Resim;
				kullaniciGuncelle.KullaniciEmail = Email;
				kullaniciGuncelle.KullaniciSifre = sifre;
				kullaniciGuncelle.PersonelMi=personelMi;
				kullaniciGuncelle.AktifMi = aktifMi;
				kullaniciGuncelle.GuncellenmeTarih=DateTime.Now;
				kullaniciGuncelle.YetkiId = yetkiId;
				kullaniciGuncelle.MusteriId = MusteriId;
				kullaniciGuncelle.MusteriId = MusteriId;
				kullaniciGuncelle.PersonelId = personelId;

				return "Güncelleme başarılı";
			}
			catch (Exception)
			{

				return "Güncelleme işlemi esnasında hata oluştu";
			}
		}

		public async Task<List<Kullanicilar>> KullaniciListesi()
		{
			//Burada await GetAllAsyncs() ifadesi asenkron olarak tüm kullanıcıları getiriyoe ve sonra result.ToList() ifadesi ile IEnumerable<Kullanicilar> türündeki bir List<Kullanicilar>`e dönüştürmüş oluyorum
			var sonuc = await GetAllAsyncs();
			return sonuc.ToList();			
		}

		public async Task<List<Kullanicilar>> KullaniciListesi(bool aktifMi)
		{
			var query = GetAllQuery(k => k.AktifMi == aktifMi);
			var sonuc = await query.ToListAsync();

			return sonuc;
		}

		public async Task<string> KullaniciSil(int kullanicilarId)
		{
			var kullaniciSil=await GetByIdAsync(kullanicilarId);
			try
			{
				if (kullaniciSil!=null)
				{
					await RemoveAsync(kullaniciSil);
					return "Silme işlemi başarılı";
				}
				else
				{
					return "Kullanıcı bulunmadı";
				}
			}
			catch (Exception)
			{

				return "Silme işlemi esnasında bir hata oluştu";
			}
		}

		public async Task<string> TopluKullaniciEkle(IEnumerable<Kullanicilar> kullanicilar)
		{
			try
			{
				await AddRangeAsync(kullanicilar);
				return "Toplu ekleme başarılı";
			}
			catch (Exception)
			{

				return "Toplu ekleme işlemi esnasında hata oluştu";
			}
		}

		public async Task<string> TopluKullaniciSil(IEnumerable<Kullanicilar> kullanicilar)
		{
			try
			{
				await RemoveRangeAsync(kullanicilar);
				return "Toplu silme başarılı";
			}
			catch (Exception)
			{

				return "Toplu silmede hata oluştu";
			}
		}
	}
}
