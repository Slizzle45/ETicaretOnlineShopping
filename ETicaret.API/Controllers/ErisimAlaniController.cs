using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ErisimAlaniController : Controller
    {
        private readonly IService<ErisimAlanlari> _service;

        public ErisimAlaniController(IService<ErisimAlanlari> service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> ErisimAlaniIndex()
        {
            var erisimAlani = await _service.GetAllAsyncs();
            return Ok(erisimAlani);
        }
    }
}
