using AutoMapper;
using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using ETicaret.Repository.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class KategorilerController : Controller
    {

        private readonly IService<Kategoriler> _service;
        private readonly IMapper _mapper;

        public KategorilerController(IService<Kategoriler> service,IMapper mapper)
        {
            _service=service;
            _mapper=mapper;
        }

        //[HttpGet]
        //public async  Task<IActionResult> KategoriIndex()
        //{
        //    var kategori= await _service.GetAllAsyncs();   

        //    return Ok(kategori);
        //}


        [HttpGet]
        public async Task<IActionResult> KategoriIndex()
        {
            var kategori = await _service.GetAllAsyncs();
            var kategoriDTO = _mapper.Map<List<KategorilerDTO>>(kategori);

            return Ok(kategori);
        }


    }
}
