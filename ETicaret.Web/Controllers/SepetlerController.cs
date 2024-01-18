using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Web.Controllers
{
    public class SepetlerController : BaseDefaultController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
