using Microsoft.AspNetCore.Mvc;

namespace BideryaMvcProject.Controllers.Nakliyat
{
    public class NakliyatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EvdenEveNakliyat()
        {
            return View();
        }
        public IActionResult UluslararasiNakliyat()
        {
            return View();
        }
        public IActionResult SehirlerArasiNakliyat()
        {
            return View();
        }
        public IActionResult AsansorluNakliyat()
        {
            return View();
        }
        public IActionResult DepoKiralama()
        {
            return View();
        }
    }
}
