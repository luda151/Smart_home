using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Smart_home.Models;
using System.Net.Http;
using static Smart_home.Models.SqlDotazy;

namespace Smart_home.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        public IActionResult Teplota()
        {
            var data = LoadTeplota();
            List<TeplotaModel> Teploty = new List<TeplotaModel>();

            foreach (var row in data)
            {
                    Teploty.Add(new TeplotaModel
                {
                        IdTeplomeru = row.IdTeplomeru,
                        Date = row.Date,
                        PosledniTeplota = row.PosledniTeplota,
                        Mistnost = row.Mistnost,
                        Umisteni = row.Umisteni,
                        NovaTeplota = row.NovaTeplota
                    });
            }
            return View(Teploty);
        }

        public IActionResult Termostat()
        {
            TeplotaModel teplotaModel = new TeplotaModel();
            teplotaModel.NactiTeplotu();
            return View(teplotaModel);
        }
        [HttpPost]
        public IActionResult Termostat(TeplotaModel teplotaModel)
        {
            teplotaModel.NactiTeplotu();
            teplotaModel.NastavTeplotu();
            return View(teplotaModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //metoda slouzici k ziskani dat z url

}
}
