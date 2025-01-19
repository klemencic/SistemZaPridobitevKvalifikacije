using Microsoft.AspNetCore.Mvc;
using UIKT_Naloga7.Models;

namespace UIKT_Naloga7.Controllers
{
    public class MinistrstvoController : Controller
    {
        public IActionResult Index()
        {
            Ministrstvo ministrstvo = new Ministrstvo();
            return View(ministrstvo);
        }

        public IActionResult Potrdi(string id)
        {
            foreach (Uporabnik uporabnik in Evidenca.Uporabniki)
            {
                foreach (Prosnja prosnja in uporabnik.Prosnje)
                {
                    if (prosnja.Stanje == "V obdelavi" && id == prosnja.Datum)
                    {
                        Evidenca.Uporabniki[Evidenca.Uporabniki.IndexOf(uporabnik)].Prosnje[uporabnik.Prosnje.IndexOf(prosnja)].Stanje = "Odobreno";
                    }
                }
            }

            Ministrstvo ministrstvo = new Ministrstvo();
            return RedirectToAction("Index");
        }

        public IActionResult Zavrni(string id)
        {
            foreach (Uporabnik uporabnik in Evidenca.Uporabniki)
            {
                foreach (Prosnja prosnja in uporabnik.Prosnje)
                {
                    if (prosnja.Stanje == "V obdelavi" && id == prosnja.Datum)
                    {
                        Evidenca.Uporabniki[Evidenca.Uporabniki.IndexOf(uporabnik)].Prosnje[uporabnik.Prosnje.IndexOf(prosnja)].Stanje = "Zavrnjeno";
                    }
                }
            }

            Ministrstvo ministrstvo = new Ministrstvo();
            return RedirectToAction("Index");
        }

        public IActionResult Odjava()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
