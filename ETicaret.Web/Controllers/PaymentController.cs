using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Web.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Payment()
        {
            return View();
        }
    }
}
