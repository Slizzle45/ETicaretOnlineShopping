using AutoMapper;
using ETicaret.Core.DTO;
using ETicaret.Core.ETicaretDatabase;
using ETicaret.Core.IService;
using ETicaret.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace ETicaret.Web.Areas.AdminPanel.Controllers
{
    public class MenulerController : Controller
    {
        private readonly IErisimAlanlariService _erisimAlaniService;
        private readonly IMenulerService _menulerService;
        private readonly IMapper _mapper;

        public MenulerController(IMenulerService service, IMapper mapper, IErisimAlanlariService erisimAlaniService)
        {
            _menulerService = service;
            _erisimAlaniService = erisimAlaniService;
            _mapper = mapper;
        }

        public async Task<IActionResult> MenulerIndex()
        {
            var menuler = await _menulerService.GetMenulerWithErisimAlanAsync();
            return View(menuler);
        }

        public async Task<IActionResult> MenuEkleIndex()
        {
            var erisimAlaniList = await _erisimAlaniService.GetAllAsyncs();
            var erisimAlaniDTO = _mapper.Map<List<ErisimAlanlariUpdateDTO>>(erisimAlaniList);
            ViewBag.erisimAlanlari = erisimAlaniDTO;

            var menuler = await _menulerService.GetAllAsyncs();
            var menulerDTO = _mapper.Map<List<MenulerUpdateDTO>>(menuler);
            ViewBag.menuler = menulerDTO;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MenuEkleIndex(Menular menu)
        {
            menu.EklenmeTarih = DateTime.Now;
            menu.AktifMi = false;
            var sonuc = await _menulerService.AddAsync(menu);

            if (sonuc != null)
            {
                return RedirectToAction("MenulerIndex");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> MenuGuncelleIndex(int id)
        {
            var getirMenu = await _menulerService.GetMenulerWithErisimAlanAsync(id);
            var erisimAlaniList = await _erisimAlaniService.GetAllAsyncs();

            var erisimAlanlari = erisimAlaniList.ToList();
            var menu = getirMenu;

            var model = new Tuple<List<ErisimAlanlari>, GetMenulerWithErisimAlanDTO>
            (erisimAlanlari, menu);

            var menuler = await _menulerService.GetAllAsyncs();
            var menulerDTO = _mapper.Map<List<MenulerUpdateDTO>>(menuler);
            ViewBag.menuler = menulerDTO;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> MenuGuncelleIndex(Menular menu)
        {
            if (ModelState.IsValid)
            {
                menu.GuncellenmeTarih = DateTime.Now;
                await _menulerService.UpdateAsync(_mapper.Map<Menular>(menu));
                TempData["guncellemeMesaj"] = "<b>Güncelleme başarılı</b>";
                return RedirectToAction("MenulerIndex");
            }

            TempData["hataMesaji"] = "<b>Güncelleme hata verdi, lütfen kontrol ediniz </b>";

            return RedirectToAction("MenuGuncelleIndex", menu.Id);
        }

        [HttpGet]
        public async Task<IActionResult> MenuSilIndex(int Id)
        {
            var menu = await _menulerService.GetByIdAsync(Id);
            return View(menu);
        }


        [HttpPost, ActionName("MenuSilIndex")]
        public async Task<IActionResult> MenuDeleteIndex(int Id, bool aktifMi)
        {
            var menu = await _menulerService.GetByIdAsync(Id);
            if (ModelState.IsValid)
            {
                await _menulerService.RemoveAsync(_mapper.Map<Menular>(menu));
                TempData["guncellemeMesaj"] = "<b>Silme başarılı</b>";
                return RedirectToAction("MenulerIndex");
            }

            TempData["hataMesaji"] = "<b>Silme hata verdi, lütfen kontrol ediniz </b>";

            return RedirectToAction("MenuSilIndex", menu.Id);
        }
    }
}
