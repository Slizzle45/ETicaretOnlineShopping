using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class FotograflarController : Controller
    {
        private readonly IService<Fotograflar> _service;

        public FotograflarController(IService<Fotograflar> service)
        {
            _service = service;
        }

        public async Task<IActionResult> FotograflarIndex()
        {
            var fotograf = await _service.GetAllAsyncs();
            return Ok(fotograf);
        }
    }
}
