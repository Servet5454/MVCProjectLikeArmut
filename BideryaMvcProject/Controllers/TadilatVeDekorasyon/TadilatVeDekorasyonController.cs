using BideryaMvcProject.DataBase;
using Microsoft.AspNetCore.Mvc;

namespace BideryaMvcProject.Controllers.TadilatVeDekorasyon
{
    public class TadilatVeDekorasyonController : Controller
    {
        private readonly BideryaMvcDatabase? context;
        private readonly IConfiguration configuration;


        public TadilatVeDekorasyonController(BideryaMvcDatabase? context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TadilatVeDekorasyon()
        {
            return View();
        }
        public IActionResult CamBalkon()
        {
            return View();
        }
        public IActionResult EvTadilat()
        {
            return View();
        }
        public IActionResult Mantolama()
        {
            return View();
        }
        public IActionResult MutfakDolabiYapimi()
        {
            return View();
        }
        public IActionResult BoyaBadana()
        {
            return View();
        }
        public IActionResult LaminantDoseme()
        {
            return View();
        }
    }
}
