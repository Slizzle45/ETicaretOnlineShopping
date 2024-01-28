using AutoMapper;
using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ETicaret.API.Controllers
{
	[ApiController]
	[Route("api/[Controller]")]
	public class KullanicilarController : BaseController
	{
		private readonly IService<Kullanicilar> _service;
		private readonly IMapper _mapper;
		private readonly IKullanicilarService _kullanicilarService;

		public KullanicilarController(IService<Kullanicilar> service,IMapper mapper,IKullanicilarService kullanicilarService)
		{
			_service = service;
			_mapper = mapper;
			_kullanicilarService = kullanicilarService;
		}
		[HttpGet("Action")]//WEB-API İÇİN OLUŞTURULDU
		public async Task<IActionResult> GetKullanicilarWithYetkiler()
		{
			return ResultAPI(await _kullanicilarService.GetKullanicilarWithYetkilerAsync());
		}


		[HttpGet]
		public async Task<IActionResult> KullaniciIndex()
		{
			var kullanicilar = await _service.GetAllAsyncs();
			var kullaniciDTO=_mapper.Map<List<KullanicilarDTO>>(kullanicilar);
			return ResultAPI(kullaniciDTO);
		}
		//[HttpGet]
		//public async Task<IActionResult> KullaniciIndex()
		//{
		//	var kullanici =await _service.GetAllAsyncs();
		//	var kullaniciDTO=_mapper.Map<List<KullanicilarDTO>>(kullanici);
		//	return Ok(kullanici);
		//}

	    
		[HttpPost]
		public async Task<IActionResult> KullanicilarSave(KullanicilarDTO kullanicilarDto)
		{
			var kullaniciSave = await _service.AddAsync(_mapper.Map<Kullanicilar>(kullanicilarDto));
			var mapAdd = _mapper.Map<KullanicilarDTO>(kullaniciSave);
			return Ok(mapAdd);
		}

		/// <summary>
		/// Burada güncellenecek olan kullanıcının id`sini ve güncelleme verileri olan KullanicilarUpdateDTO parametresini aldım.GetByIdAsync metodu ile de id, ye göre güncellenecek kullanıcı bulunur,ardından _mapper.Map ile DTO`dan aldığım verileri varolan kullanıcı nesnesine atanır ve güncelleme işlemi yapılır
		/// </summary>
		/// <param name="kullanicilarDto"></param>
		/// <returns></returns>
		[HttpPut("KullanicilarUpdate")]
		public async Task<IActionResult> KullanicilarUpdate(KullanicilarUpdateDTO kullaniciupdateDto)
		{
			var getKullanici =await _service.GetByIdAsync(kullaniciupdateDto.Id);
			if (getKullanici!=null)
			{
				await _service.UpdateAsync(_mapper.Map<Kullanicilar>(kullaniciupdateDto));
				return Ok();
			}
			//await _service.UpdateAsync(_mapper.Map<Kullanicilar>(kullaniciupdateDto));
			else
			{
				return NoContent();
				
			}
			
		}

		/// <summary>
		/// KullaniciSil metodu ile silinecek olan kullanıcının id`sini alır ve GetByIdAsync ile de id verip kullanıcı id ile bulurum ve DeleteAsync metodu ile de kullanıcı silinir.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpDelete("id")]
		public async Task<IActionResult> KullaniciSil(int id)
		{
			var getKullanici=await _service.GetByIdAsync(id);
			if (getKullanici==null)
			{
				return NotFound();
			}
			else
			{
				await _service.RemoveAsync(getKullanici);
				return NoContent();
			}
		}
		//Id ye göre kullanıcıyı bana getirir
		[HttpGet("KullaniciGetById")]
		public async Task<IActionResult> KullaniciGetById(int id)
		{
			var getKullanici=await _service.GetByIdAsync(id);
			return Ok(getKullanici);
		}


		//Bu metod kullanıcılar tablomdaki bütün verileri bana getirir
		[HttpGet("GetKullanicilarWithYetkilerDTO")]
		public async Task<IActionResult> GetKullanicilarWithYetkilerDTO()
		{
			var kullanici = await _service.GetAllAsyncs();
			var kullaniciDTO=_mapper.Map<List<GetKullanicilarWithYetkilerDTO>>(kullanici);
			return Ok(kullaniciDTO);
		}
	}
}
