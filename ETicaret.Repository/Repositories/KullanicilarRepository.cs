using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.Repositories
{
	public class KullanicilarRepository : GenericRepository<Kullanicilar>, IKullanicilarRepository
	{
		public KullanicilarRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
		{
		}

		public async Task<string> KullaniciEkle(string Adi, string Soyadi, string Resim, string KullaniciEmail, string KullaniciSifre, bool PersonelMi, int YetkiId, int MusteriId, int PersonelID)
		{
			try
			{
				Kullanicilar kullaniciEkle = new Kullanicilar();
				kullaniciEkle.Adi = Adi;
				kullaniciEkle.Soyadi = Soyadi;
				kullaniciEkle.KullaniciResim = Resim;
				kullaniciEkle.KullaniciEmail = KullaniciEmail;
				kullaniciEkle.KullaniciSifre = KullaniciSifre;
				kullaniciEkle.PersonelMi = PersonelMi;
				kullaniciEkle.YetkiId = YetkiId;
				kullaniciEkle.PersonelId = PersonelID;
				await AddAsync(kullaniciEkle);

				return "Ekleme Başarılı";
			}
			catch (Exception)
			{

				return "Ekleme işlemi esnasında hata oluştu";
			}
			
		}

		public async Task<string> KullaniciGuncelle(int KullanicilarId, string Adi, string Soyadi, string Resim, string KullaniciEmail, string KullaniciSifre, bool PersonelMi, bool aktifMi, DateTime EklenmeTarihi, int YetkiId, int MusteriId, int PersonelID)
		{
			var kullaniciGuncelle = await GetByIdAsync(KullanicilarId);
			try
			{
				kullaniciGuncelle.Adi = Adi;
				kullaniciGuncelle.Soyadi = Soyadi;
				kullaniciGuncelle.KullaniciResim = Resim;
				kullaniciGuncelle.KullaniciEmail = KullaniciEmail;
				kullaniciGuncelle.KullaniciSifre = KullaniciSifre;
				kullaniciGuncelle.PersonelMi = PersonelMi;
				kullaniciGuncelle.AktifMi = aktifMi;
				kullaniciGuncelle.EklenmeTarih = EklenmeTarihi;
				kullaniciGuncelle.GuncellenmeTarih = DateTime.Now;
				kullaniciGuncelle.YetkiId = YetkiId;
				kullaniciGuncelle.MusteriId = MusteriId;
				kullaniciGuncelle.PersonelId = PersonelID;

				return "Güncelleme işlemi başarılı";

			}
			catch (Exception)
			{

				return "Güncelleme işlemi esnasında hata oluştu";
			}
		}

		public async Task<List<Kullanicilar>> KullaniciListesi()
		{
				return await GetAll().ToListAsync();
		}

		public async Task<List<Kullanicilar>> KullaniciListesi(bool aktifMi)
		{
			return await GetAllQuery(k=>k.AktifMi==aktifMi).ToListAsync();
		}

		public async Task<string> KullaniciSil(int KullanicilarId)
		{
			var kullaniciSil =await GetByIdAsync(KullanicilarId);

			try
			{
				if (kullaniciSil!=null)
				{
					Remove(kullaniciSil);
				    await _eTicaretDB.SaveChangesAsync();
					return "Silme işlemi başarılı";

				}
				else
				{
					return "Kullanıcı bulunamadı";
				}
			}
			catch (Exception)
			{

				return "Silme işlemi esnasında hata oluştu";
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

		public  async Task<string> TopluKullaniciSil(IEnumerable<Kullanicilar> kullanicilar)
		{
			try
			{
				 RemoveRange(kullanicilar);
				 return  "Toplu silme işlemi başarılı";
			}
			catch (Exception)
			{

				return "Toplu silme işlemi esnasında hata oluştu";
			}
		}
	}
}
