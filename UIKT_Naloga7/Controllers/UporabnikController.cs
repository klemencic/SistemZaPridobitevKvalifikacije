using Microsoft.AspNetCore.Mvc;
using UIKT_Naloga7.Models;

namespace UIKT_Naloga7.Controllers
{
    public class UporabnikController : Controller
    {
        public IActionResult Index()
        {
            Uporabnik uporabnik = Evidenca.Uporabniki.Find(x => x.UporabniskoIme == TempData["UporabniskoIme"].ToString() && x.Geslo == TempData["Geslo"].ToString());
            TempData["UporabniskoIme"] = uporabnik.UporabniskoIme;
            TempData["Geslo"] = uporabnik.Geslo;

            return View(uporabnik);
        }

        public IActionResult Odjava()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult NovaProsnja()
        {
            return RedirectToAction("Prosnja");
        }

        [HttpGet]
        public IActionResult Prosnja()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Prosnja(Prosnja model)
        {
            int indeks = Evidenca.Uporabniki.IndexOf(Evidenca.Uporabniki.Find(x => x.UporabniskoIme == TempData["UporabniskoIme"].ToString() && x.Geslo == TempData["Geslo"].ToString()));
            Evidenca.Uporabniki[indeks].Prosnje.Add(model);

            TempData["SuccessMessage"] = "Uspešno poslano";

            return RedirectToAction("Index");
        }
    }
}
