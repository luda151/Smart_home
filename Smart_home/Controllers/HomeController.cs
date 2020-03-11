using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Smart_home.Models;
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
                        Umisteni = row.Umisteni
                    });
            }
            return View(Teploty);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
