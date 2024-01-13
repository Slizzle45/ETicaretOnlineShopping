using AutoMapper;
using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MenulerController : Controller
    {
        private readonly IService<Menular> _service;
        private readonly IMapper _mapper;

        public MenulerController(IService<Menular> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> MenulerIndex()
        {
            var menuler = await _service.GetAllAsyncs();
            var menulerDTO = _mapper.Map<List<MenulerDTO>>(menuler);
            return Ok(menulerDTO);
        }

        [HttpPost]
        public async Task<IActionResult> MenulerSave(MenulerDTO menulerDTO)
        {
            var menuSave = await _service.AddAsync(_mapper.Map<Menular>(menulerDTO));
            var mapAdd = _mapper.Map<MenulerDTO>(menuSave);
            return Ok(menulerDTO);
        }

        [HttpPut("MenulerUpdate")]
        public async Task<IActionResult> MenulerUpdate(MenulerUpdateDTO menuUpdateDTO)
        {
            var getMenu = await _service.GetByIdAsync(menuUpdateDTO.Id);

            if (getMenu != null)
            {
                await _service.UpdateAsync(_mapper.Map<Menular>(menuUpdateDTO));
                return Ok();
            }
            else
            {
                return NoContent();
            }
        }

        [HttpDelete]
        public async Task<IActionResult> MenulerRemove(int id)
        {
            var getMenu = await _service.GetByIdAsync(id);

            if (getMenu != null)
            {
                await _service.RemoveAsync(getMenu);
                return Ok();
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("MenuGetById/{id}")]
        public async Task<IActionResult> MenuGetById(int id)
        {
            var getMenu = await _service.GetByIdAsync(id);

            return Ok(getMenu);
        }

        [HttpGet("GetMenulerWithErisimAlan")]
        public async Task<IActionResult> GetMenulerWithErisimAlan()
        {
            var menuler = await _service.GetAllAsyncs();
            var menulerDTO = _mapper.Map<List<GetMenulerWithErisimAlanDTO>>(menuler);
            return Ok(menulerDTO);
        }

    }
}
