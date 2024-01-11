using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MenulerController : Controller
    {
        private readonly IService<Menular> _service;

        public MenulerController(IService<Menular> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> MenuIndex()
        {
            var menu = await _service.GetAllAsyncs();
            return Ok(menu);
        }
    }
}
