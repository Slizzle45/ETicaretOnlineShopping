using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class YorumlarController : Controller
    {
        private readonly IService<Yorumlar> _service;

        public YorumlarController(IService<Yorumlar> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> YorumlarIndex()
        {
            var yorumlar = await _service.GetAllAsyncs();
            return Ok(yorumlar);
        }
    }
}
