using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AdreslerController : Controller
    {
        private readonly IService<Adresler> _service;

        public AdreslerController(IService<Adresler> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var adres =await _service.GetAllAsyncs();
            return Ok(adres);
        }
    }
}
