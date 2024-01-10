using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.Repositories
{
    public class AdreslerRepository : GenericRepository<Adresler>, IAdreslerRepository
    {
        private readonly AppDbContext _db;
        public AdreslerRepository(AppDbContext eTicaretDB) : base(eTicaretDB)
        {
            _db = eTicaretDB;
        }

        public Task<Adresler> AddAsync(string adresbasligi, string adres, string postaKodu, int ilKodu, int ilceKodu, int musteriId)
        {
            throw new NotImplementedException();
            //try
            //{
            //    Adresler adresler = new Adresler();
            //    adresler.AdresBasligi = adresbasligi;
            //    adresler.Adres = adres;
            //    adresler.PostaKodu = postaKodu;
            //    adresler.IlKodu = ilKodu;
            //    adresler.IlceKod = ilceKodu;
            //    AddAsync(adresler);
            //    return;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        public Task<Adresler> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Adresler>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Adresler> GetIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Adresler> UpdateAsync(int id, string adresbasligi, string adres, string postaKodu, int ilKodu, int ilceKodu)
        {
            throw new NotImplementedException();
        }
    }
}
