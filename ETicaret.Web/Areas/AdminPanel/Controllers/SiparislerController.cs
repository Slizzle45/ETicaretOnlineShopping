using AutoMapper;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Web.Areas.AdminPanel.Controllers
{
    public class SiparislerController : Controller
    {
        private readonly ISiparislerService _service;
        private readonly IKullanicilarService _kullanicilarService;
        private readonly IMusterilerService _musterilerService;
        private readonly IMapper _mapper;

        public SiparislerController(ISiparislerService service, IKullanicilarService kullanicilarService, IMusterilerService musterilerService, IMapper mapper)
        {
            _service = service;
            _kullanicilarService = kullanicilarService;
            _musterilerService = musterilerService;
            _mapper = mapper;
        }

        public async Task<IActionResult> SiparislerIndex()
        {
            var siparisler = await _service.GetSiparislerWithMusterilerAsync();
            //var urunlerDTO = _mapper.Map<List<GetUrunlerWithKategoriDTO>>(urunler);
            return View(siparisler);
        }
    }
}
