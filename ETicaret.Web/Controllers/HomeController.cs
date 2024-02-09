using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using ETicaret.Service.Services;
using ETicaret.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ETicaret.Web.Controllers
{
    public class HomeController : BaseDefaultController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IService<Kategoriler> _kategoriService;
        private readonly IService<Urunler> _urunService;
        private readonly IService<Fotograflar> _fotografService;

        public HomeController(ILogger<HomeController> logger, IService<Fotograflar> fotografService, IService<Urunler> urunService, IService<Kategoriler> kategoriService)
        {
            _logger = logger;
            _fotografService = fotografService;
            _urunService = urunService;
            _kategoriService = kategoriService;
        }

        public async Task<IActionResult> Index()
        {
            var kategoriler = await _kategoriService.GetAllAsyncs();
            var urunler = await _urunService.GetAllAsyncs();
            var fotograflar = await _fotografService.GetAllAsyncs();

            var model = new UrunlerViewModel
            {
                Kategoriler = kategoriler,
                Urunler = urunler,
                Fotograflar = fotograflar
            };

            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ItemDetails()
        {
            return View();
        }
    }
}
