using ETicaret.Core.ETicaretDatabase;

namespace ETicaret.Web.Models
{
    public class UrunlerViewModel
    {
        public IEnumerable<Urunler> Urunler { get; set; }
        public IEnumerable<Kategoriler> Kategoriler { get; set; }
        public IEnumerable<Fotograflar> Fotograflar { get; set; }
    }
}
