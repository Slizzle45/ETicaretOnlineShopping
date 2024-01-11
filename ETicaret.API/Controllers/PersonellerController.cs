using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
	[ApiController]
	[Route("api/[Controller]")]
	public class PersonellerController : Controller
	{
		private readonly IService<Personeller> _service;

		public PersonellerController(IService<Personeller> service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<IActionResult> PersonelIndex()
		{
			var personel = await _service.GetAllAsyncs();
			return View(personel);
		}
	}
}
