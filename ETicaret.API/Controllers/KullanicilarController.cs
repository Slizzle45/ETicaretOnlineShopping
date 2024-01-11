using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
	[ApiController]
	[Route("api/[Controller]")]
	public class KullanicilarController : Controller
	{
		private readonly IService<Kullanicilar> _service;

		public KullanicilarController(IService<Kullanicilar> service)
		{
			_service = service;
		}
		[HttpGet]
		public async Task<IActionResult> KullaniciIndex()
		{
			var kullanici =await _service.GetAllAsyncs();
			return Ok(kullanici);
		}
	}
}
