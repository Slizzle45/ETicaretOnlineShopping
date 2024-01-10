using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class UrunlerController : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
