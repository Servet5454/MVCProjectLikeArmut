using Microsoft.AspNetCore.Mvc;

namespace BideryaMvcProject.Controllers.Temizlik
{
    public class TemizlikIlanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KoltukTemizlik()
        {
            return View();
        }
    }
}
