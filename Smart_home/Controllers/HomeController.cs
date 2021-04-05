using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Smart_home.Models;
using Smart_home.Service;

namespace Smart_home.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDbService _DbService;

        public HomeController(ILogger<HomeController> logger, IDbService DbService)
        {
            _logger = logger;
            _DbService = DbService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Check()
        {
            
            return RedirectToAction("Index");
        }


        public IActionResult Control()
        {
            return View();
        }

        public IActionResult Termostat()
        {
            Termostat teplotaModel = new();
            Teploty teploty = new();
            teploty = _DbService.nactiZDb(teploty);
            teplotaModel.PosledniTeplota = teploty.teplota;
            //teplotaModel.NastavenaTeplota = teploty.vratNastavenouTeplotu(teploty);

            return View(teplotaModel);
        }

        public IActionResult Co2()
        {
            Co2 co2 = new();
            co2 = _DbService.nactiZDb2(co2);
            return View(co2);
        }

        public IActionResult Zvonek()
        {
            return View();
        }

        public IActionResult Pocasi()
        {
            return View();
        }

        public IActionResult Zabezpeceni()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Termostat(Termostat teplotaModel)
        //{

        //    return View(teplotaModel);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
