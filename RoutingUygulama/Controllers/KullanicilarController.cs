using Microsoft.AspNetCore.Mvc;
using RoutingUygulama.Data;

namespace RoutingUygulama.Controllers
{
    public class KullanicilarController : Controller
    {
        static readonly List<Kullanici> kullanicilar = new()
        {
            new Kullanici { Yas = 20, DaireNo = "1", Sifre = "123" },
            new Kullanici { Yas = 30, DaireNo = "2", Sifre = "123" },
            new Kullanici { Yas = 40, DaireNo = "3", Sifre = "123" },
        };
        public IActionResult Index()
        {
            return View(kullanicilar);
        }

        public IActionResult Yeni()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Yeni(Kullanici kullanici)
        {

            if (ModelState.IsValid)
            {
                kullanicilar.Add(kullanici);
                return RedirectToAction("Index");
            }
            return View(kullanici);
        }


    }
}
