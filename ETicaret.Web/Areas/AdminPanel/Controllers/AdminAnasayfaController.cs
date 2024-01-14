using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Web.Areas.AdminPanel.Controllers
{
    public class AdminAnasayfaController : Controller
    {
        public IActionResult AdminAnasayfaIndex()
        {
            return View();
        }

        public IActionResult AdminPartial()
        {
            return View();
        }
    }
}
