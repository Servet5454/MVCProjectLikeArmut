using Microsoft.AspNetCore.Mvc;

namespace BideryaMvcProject.Controllers
{
    public class BilgiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hakkimizda()
        {
            return View();
        }
    }
}
