using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class SiparislerController : Controller
    {
        private readonly IService<Siparisler> _service;

        public SiparislerController(IService<Siparisler> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var siparis = await _service.GetAllAsyncs();
            return Ok(siparis);
        }
    }
}
