using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using ETicaret.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class YetkiErisimController : BaseController
    {
        private readonly IService<YetkiErisim> _service;

        public YetkiErisimController(IService<YetkiErisim> service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> YetkiErisimIndex()
        {
            var yetkiErisim = await _service.GetAllAsyncs();
            return ResultAPI(yetkiErisim);
        }
        [HttpPost]
        public async Task<IActionResult> YetkiErisimSave(YetkiErisim yetkiErisim)
        {
            var yetkiErisimSave = await _service.AddAsync(yetkiErisim);
            return ResultAPI(yetkiErisimSave);
        }
        [HttpPut]
        public async Task<IActionResult> YetkiErisimUpdate(YetkiErisim yetkiErisim)
        {
            if (yetkiErisim != null)
            {
                await _service.UpdateAsync(yetkiErisim);
                return ResultAPI(yetkiErisim);

            }
            else
            {
                return NoContent();
            }

        }
        [HttpDelete]
        public async Task<IActionResult> YetkiErisimDelete(YetkiErisim yetkiErisim)
        {

            if (yetkiErisim != null)
            {
                await _service.RemoveAsync(yetkiErisim);
                return Ok();

            }
            else
            {
                return NoContent();
            }

        }
        [HttpGet("YetkiIdErisimIdWithList/{yetkiId:int}/{erisimAlanId:int}")]
        public async Task<IActionResult> YetkiIdErisimIdWithList(int yetkiId, int erisimAlanId)
        {
            var yetkiErisim = await _service.GetAllQuery(k => k.YetkiId == yetkiId && k.ErisimAlaniId == erisimAlanId).FirstOrDefaultAsync();
            return ResultAPI(yetkiErisim);
        }
        [HttpGet("YetkiIdWithList/{id:int}")]
        public async Task<IActionResult> YetkiIdWithList(int id)
        {
            var yetkiErisim = await _service.GetAllQueryAsync(k => k.YetkiId == id);
            return ResultAPI(yetkiErisim);
        }
        [HttpGet("ErisimIdWithList/{id:int}")]
        public async Task<IActionResult> ErisimIdWithList(int id)
        {
            var yetkiErisim = await _service.GetAllQueryAsync(k => k.ErisimAlaniId == id);
            return ResultAPI(yetkiErisim);
        }
    }
}
