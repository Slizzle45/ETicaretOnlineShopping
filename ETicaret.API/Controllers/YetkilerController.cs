using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class YetkilerController : Controller
    {
        private readonly IService<Yetkiler> _service;

        public YetkilerController(IService<Yetkiler> service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> YetkilerIndex()
        {
            var yetki = await _service.GetAllAsyncs();
            return Ok(yetki);
        }
    }
}
