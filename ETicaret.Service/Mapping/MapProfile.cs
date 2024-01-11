using AutoMapper;//AutoMapper.Extention.MS.DI
using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using ETicaret.Repository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Service.Mapping
{

    //MapPrpfile için AutoMapper Nuget'ten eklenmesi gereklidir
    //AutoMapper.Extention.MS.DI ===>for .Net core bunun eklenmsi gereklidir
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Urunler, UrunlerDTO>().ReverseMap();
            //Urunler nesnesi yerine UrunlerDTO nesnesi kullanılacak anlamına geliyor, ReverseMap ise bu olayın tam tersi de gerçekleşebiliri yani UrunlerDTO yerine Urunler nesnesi kullanılabilir
            CreateMap<Urunler, GetUrunlerWithKategoriDTO>().ReverseMap();
            CreateMap<Kategoriler, KategorilerDTO>().ReverseMap();

        }

    }
}
