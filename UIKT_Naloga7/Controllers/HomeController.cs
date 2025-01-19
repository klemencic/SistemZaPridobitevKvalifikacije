using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UIKT_Naloga7.Models;

namespace UIKT_Naloga7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Uporabnik model)
        {
            if(Evidenca.PreveriUporabnika(model.UporabniskoIme, model.Geslo))
            {
                TempData["UporabniskoIme"] = model.UporabniskoIme;
                TempData["Geslo"] = model.Geslo;
                return RedirectToAction("Index", "Uporabnik");
            }
            else if(model.UporabniskoIme == "admin" && model.Geslo == "admin")
            {
                TempData["UporabniskoIme"] = model.UporabniskoIme;
                TempData["Geslo"] = model.Geslo;
                return RedirectToAction("Index", "Ministrstvo");
            }
                return View();
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
