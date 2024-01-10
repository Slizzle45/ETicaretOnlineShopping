using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class KategorilerController : Controller
    {

        private readonly IService<Kategoriler> _service;

        public KategorilerController(IService<Kategoriler> service)
        {
            _service=service;
        }

        [HttpGet]
        public async  Task<IActionResult> KategoriIndex()
        {
            var kategori= await _service.GetAllAsyncs();   
            return Ok(kategori);
        }


    }
}
