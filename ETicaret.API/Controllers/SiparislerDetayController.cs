using AutoMapper;
using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SiparislerDetayController : BaseController
    {
        private readonly IService<SiparisDetay> _service;
        private readonly IMapper _mapper;
        readonly ISiparislerDetayService _siparisDetayService;
#warning dto eklenecek
        public SiparislerDetayController(IService<SiparisDetay> service, IMapper mapper, ISiparislerDetayService siparisDetayService)
        {
            _service = service;
            _mapper = mapper;
            _siparisDetayService = siparisDetayService;
        }

        [HttpGet]
        public async Task<IActionResult> SiparislerDetayIndex()
        {
            var siparisDetay = await _service.GetAllAsyncs();
            var siparisDetayDto = _mapper.Map<List<SiparisDetayDTO>>(siparisDetay);
            return ResultAPI(siparisDetayDto);
        }

        [HttpPost]
        public async Task<IActionResult> SiparislerDetaySave(SiparisDetayDTO siparisDetayDTO)
        {
            var siparisDetaySave = await _service.AddAsync(_mapper.Map<SiparisDetay>(siparisDetayDTO));
            var mapAdd = _mapper.Map<SiparisDetayDTO>(siparisDetaySave);

            return Ok(mapAdd);
        }

        [HttpPut]
        public async Task<IActionResult> SiparislerDetayUpdate(SiparisDetayUpdateDTO siparisDetayUpdate)
        {
            var getSiparisDetay = await _service.GetByIdAsync(siparisDetayUpdate.Id);

            if (getSiparisDetay != null)
            {
                await _service.UpdateAsync(_mapper.Map(siparisDetayUpdate, getSiparisDetay));
            }
            else
            {
                return NoContent();
            }

            return ResultAPI(getSiparisDetay);
        }
    }
}
