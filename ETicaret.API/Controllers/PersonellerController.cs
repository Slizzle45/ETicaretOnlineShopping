using AutoMapper;
using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
	[ApiController]
	[Route("api/[Controller]")]
	public class PersonellerController : BaseController
	{
		private readonly IService<Personeller> _service;
		private readonly IMapper _mapper;
		private readonly IPersonellerService _personelService;

		public PersonellerController(IService<Personeller> service,IMapper mapper,IPersonellerService personellerService)
		{
			_service = service;
			_mapper = mapper;
			_personelService = personellerService;
		}

		[HttpGet("Action")]//WEB-API KATMANINDA PersonellerApıService CLASSI İÇİN OLUŞTURLDU
		public async Task<IActionResult> GetPersonellerWithKullanicilar()
		{
			return ResultAPI(await _personelService.GetPersonellerWithKullanicilarAsync());

		}

		[HttpGet]
		public async Task<IActionResult> PersonelIndex()
		{
			var personel = await _service.GetAllAsyncs();
			var personelDto=_mapper.Map<List<Personeller>>(personel);
			return View(personel);
		}

		/// <summary>
		/// Kayıt işlemi yapar
		/// </summary>
		/// <param name="PersonellerDto"></param>
		/// <returns></returns>
		[HttpPost]
		public async Task<IActionResult> PersonellerSave(PersonellerDTO PersonellerDto)
		{
			var personelSave = await _service.AddAsync(_mapper.Map<Personeller>(PersonellerDto));
			var mapAdd=_mapper.Map<PersonellerDTO>(personelSave);
			return Ok(mapAdd);
		}

		[HttpPut("PersonelUpdate")]
		public async Task<IActionResult> PersonelUpdate(PersonellerUpdateDTO personelupdateDto)
		{
			var getPersonel = await _service.GetByIdAsync(personelupdateDto.Id);
			if (getPersonel != null)
			{
				await _service.UpdateAsync(_mapper.Map<Personeller>(personelupdateDto));
				return Ok();
			}
			
			else
			{
				return NoContent();
				return Ok(_mapper.Map<PersonellerDTO>(getPersonel));

			}

		}
		[HttpDelete("id")]
		public async Task<IActionResult> PersonelSil(int id)
		{
			var getPersonel = await _service.GetByIdAsync(id);
			if (getPersonel == null)
			{
				return NotFound();
			}
			else
			{
				await _service.RemoveAsync(getPersonel);
				return NoContent();
			}
		}
		[HttpGet("PersonelGetById/{id}")]
		public async Task<IActionResult> PersonelGetById(int id)
		{
			var getPersonel=await _service.GetByIdAsync(id);
			return Ok(getPersonel);
		}

		[HttpGet("GetPersonellerWithKullanicilarDTO")]
		public async Task<IActionResult> GetPersonelWithKullanicilar()
		{
			var personel = await _service.GetAllAsyncs();
			var personelDTO=_mapper.Map<List<GetPersonellerWithKullanicilarDTO>>(personel);
			return Ok(personelDTO);
		}
	}
}
