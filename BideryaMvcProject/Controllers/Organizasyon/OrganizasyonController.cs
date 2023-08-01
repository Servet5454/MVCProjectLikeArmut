using Microsoft.AspNetCore.Mvc;

namespace BideryaMvcProject.Controllers.Organizasyon
{
    public class OrganizasyonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DugunOrganizasyon()
        {
            return View();
        }
        public IActionResult DogumGunuOrganizasyon()
        {
            return View();
        }
        public IActionResult EvlilikTeklifOrganizasyon()
        {
            return View();
        }
        public IActionResult YatKiralama()
        {
            return View();
        }
        public IActionResult Catering()
        {
            return View();
        }
    }
}
