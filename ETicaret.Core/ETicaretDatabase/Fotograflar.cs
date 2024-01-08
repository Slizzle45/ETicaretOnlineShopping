using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.ETicaretDatabase
{
    public class Fotograflar : BaseEntity
    {
        // AHMET YÜKSEL

        public string FotografYolu { get; set; }
        // Fotoğrafın yolu için.
        public string FotografAciklamasi { get; set; }
        /*= "image" + Guid.NewGuid().ToString();*/
        // Fotoğrafın açıklaması yoksa default olarak 'image' + Guid oluşturulur.
        public byte? FotografSirasi { get; set; }
        // Fotoğrafın sırası yoksa sayfada rastgele sıralanması sağlanabilir.
        //public DateTime FotografPasiflikTarihi { get; set; }
        //// Fotoğrafın pasif edilme tarihi için.
        public int UrunId { get; set; }
        public Urunler Urunler { get; set; }
        //1,2,3,4//0-255
    }
}
