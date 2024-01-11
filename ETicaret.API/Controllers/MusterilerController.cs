using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MusterilerController : Controller
    {
        private readonly IService<Musteriler> _service;

        public MusterilerController(IService<Musteriler> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> MusteriIndex()
        {
            var musteri = await _service.GetAllAsyncs();
            return Ok(musteri);
        }
    }
}
