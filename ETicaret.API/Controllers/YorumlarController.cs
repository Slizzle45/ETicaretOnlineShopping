using AutoMapper;
using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class YorumlarController : BaseController
    {
        private readonly IService<Yorumlar> _service;
        private readonly IMapper _mapper;
        readonly IYorumlarService _yorumlarService;

        public YorumlarController(IService<Yorumlar> service,IMapper mapper, IYorumlarService yorumlarService)
        {
            _service = service;
            _mapper = mapper;
            _yorumlarService = yorumlarService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetYorumlarWithKullanicilar()
        {

            return ResultAPI(await _yorumlarService.GetYorumlarWithKullanicilarAsync());
        }

        [HttpGet]
        public async Task<IActionResult> YorumlarIndex()
        {
            var yorumlar = await _service.GetAllAsyncs();
            var yorumlarDTO = _mapper.Map<List<YorumlarDTO>>(yorumlar);
            return ResultAPI(yorumlarDTO);
        }

        [HttpPost]
        public async Task<IActionResult> YorumlarSave(YorumlarDTO yorumlarDTO)
        {
            var yorumSave = await _service.AddAsync(_mapper.Map<Yorumlar>(yorumlarDTO));
            var mapAdd = _mapper.Map<YorumlarDTO>(yorumSave);
            return Ok(mapAdd);
        }

        [HttpPut("YorumlarUpdate")]
        public async Task<IActionResult> YorumlarUpdate(YorumlarUpdateDTO yorumUpdateDTO)
        {
            var getYorum = await _service.GetByIdAsync(yorumUpdateDTO.Id);

            if (getYorum != null)
            {
                await _service.UpdateAsync(_mapper.Map(yorumUpdateDTO, getYorum));
            }
            else
            {
                return NoContent();
            }

            return ResultAPI(yorumUpdateDTO);
        }

        [HttpDelete]
        public async Task<IActionResult> YorumRemove(int id)
        {
            var yorumRemove = await _service.GetByIdAsync(id);

            if (yorumRemove != null)
            {
                await _service.RemoveAsync(yorumRemove);
                return Ok();
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("GetYorumlarWithKullanicilar/{id}")]
        public async Task<IActionResult> YorumGetById(int id)
        {
            var getYorum = await _service.GetByIdAsync(id);
            return Ok(getYorum);
        }
    
    }
}
