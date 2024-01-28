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
    public class YetkilerController : BaseController
    {
        private readonly IService<Yetkiler> _service;
        private readonly IService<YetkiErisim> _yetkiErisimService;
        private readonly IService<ErisimAlanlari> _erisimAlanService;
        private readonly IYetkilerService _yetkiService;
        private readonly IMapper _mapper;

        public YetkilerController(IService<Yetkiler> service, IMapper mapper, IService<YetkiErisim> yetkiErisimService, IYetkilerService yetkilerService, IService<ErisimAlanlari> erisimAlanSevice)
        {
            _service = service;
            _mapper = mapper;
            _yetkiErisimService = yetkiErisimService;
            _yetkiService = yetkilerService;
            _erisimAlanService = erisimAlanSevice;
        }
        [HttpGet("Yetkiler")]
        public async Task<IActionResult> YetkilerIndex()
        {
            var yetki = await _yetkiService.GetYetkiler();
            var yetkiDto = _mapper.Map<List<YetkilerDTO>>(yetki);
            return ResultAPI(yetki);
        }
        //[HttpGet]
        //public async Task<IActionResult> YetkilerIndex()
        //{
        //    var yetki = await _service.GetAllAsyncs();
        //    var yetkiDto = _mapper.Map<List<YetkilerDTO>>(yetki);
        //    return Ok(yetkiDto);
        //}
        [HttpPost]
        public async Task<IActionResult> YetkiSave(YetkilerDTO yetkilerDTO)
        {
            var mapYetki = _mapper.Map<Yetkiler>(yetkilerDTO);
            mapYetki.AktifMi = true;
            var yetkiSave = await _service.AddAsync(mapYetki);
            var mapAdd = _mapper.Map<YetkilerDTO>(yetkiSave);
            return ResultAPI(mapAdd);
        }
        //[HttpPut("/{yetkiId:int}")] böyle de yapılabilir.
        [HttpPut]
        public async Task<IActionResult> YetkiUpdate(YetkilerUpdateDTO yetkiler)
        {
            var getYetki = await _service.GetByIdAsync(yetkiler.Id);
            if (getYetki != null)
            {
                yetkiler.AktifMi = true;
                _mapper.Map(yetkiler, getYetki);
                await _service.UpdateAsync(getYetki);

                return ResultAPI(yetkiler);
            }
            else
            {
                return NoContent();
            }

        }
        [HttpDelete]
        public async Task<IActionResult> YetkiDelete(int id)
        {
            var getYetki = await _service.GetByIdAsync(id);
            var getYetkiErisim = _yetkiErisimService.GetAllQuery(a => a.YetkiId == id).ToList();


            if (getYetki != null || getYetkiErisim != null)
            {
                foreach (var item in getYetkiErisim)
                {
                    if (item != null)
                    {
                        var nesne = _yetkiErisimService.GetAllQuery(k => k.YetkiId == item.YetkiId && k.ErisimAlaniId == item.ErisimAlaniId).FirstOrDefault();
                        await _yetkiErisimService.RemoveAsync(nesne);
                    }
                }
                await _yetkiService.YetkiSilAsync(id);
                return ResultAPI(getYetki);
            }
            else
            {
                return NoContent();
            }

        }

        [HttpGet("YetkiBulWithId/{id:int}")]
        public async Task<IActionResult> YetkiBul(int id)
        {
            var yetkiVarMi = await _yetkiService.GetAllQuery(k => k.Id == id).FirstOrDefaultAsync();
            if (yetkiVarMi != null)
            {
                //var yetkiDto = _mapper.Map<YetkilerDTO>(yetkiVarMi);

                return ResultAPI(yetkiVarMi);

            }
            else
            {
                return NoContent();

            }
        }
        [HttpGet("YetkiBulWithName")]
        public async Task<IActionResult> YetkiBulWithName(string name)
        {
            var yetkiVarMi = await _yetkiService.GetAllQuery(k => k.YetkiAdi == name).FirstOrDefaultAsync();
            if (yetkiVarMi != null)
            {
                var yetkiDto = _mapper.Map<YetkilerDTO>(yetkiVarMi);

                return ResultAPI(yetkiDto);

            }
            else
            {
                return NoContent();

            }
        }

        [HttpGet("YetkilerGetById/{id:int}")]
        public async Task<IActionResult> YetkilerGetById(int id)
        {
            var yetki = await _service.GetByIdAsync(id);
            if (yetki != null)
            {
                var yetkiDto = _mapper.Map<YetkilerDTO>(yetki);
                return ResultAPI(yetkiDto);

            }
            else
            {
                return NoContent();

            }
        }

    }
}
