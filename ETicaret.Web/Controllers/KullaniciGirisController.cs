using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Web.Controllers
{
    public class KullaniciGirisController : BaseDefaultController
    {
        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
