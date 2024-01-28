using AutoMapper;
using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class SiparislerController : BaseController
    {
        private readonly IService<Siparisler> _service;
        private readonly IMapper _mapper;

#warning DTO oluşturulacak
        public SiparislerController(IService<Siparisler> service, IMapper mapper) 
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> SiparislerIndex()
        {
            var siparisler = await _service.GetAllAsyncs();
            var siparislerDTO = _mapper.Map<List<SiparislerDTO>>(siparisler);
            return Ok(siparislerDTO);
        }

        [HttpPost]
        public async Task<IActionResult> SiparislerSave(SiparislerDTO siparislerDto)
        {
            var siparisSave = await _service.AddAsync(_mapper.Map<Siparisler>(siparislerDto));
            var mapAdd = _mapper.Map<UrunlerDTO>(siparisSave);

            return Ok(mapAdd);
        }

        [HttpPut]
        public async Task<IActionResult> SiparislerUpdate(SiparislerUpdateDTO siparislerDto)
        {
            var getUrun = await _service.GetByIdAsync(siparislerDto.Id);

            if (getUrun != null)
            {
                await _service.UpdateAsync(_mapper.Map(siparislerDto, getUrun));
            }
            else
            {
                return NoContent();
            }

            return ResultAPI(siparislerDto);
        }
    }
}
