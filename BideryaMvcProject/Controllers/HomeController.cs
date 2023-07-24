using BideryaMvcProject.DataBase;
using BideryaMvcProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BideryaMvcProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BideryaMvcDatabase context;

        public HomeController(ILogger<HomeController> logger, BideryaMvcDatabase context)
        {
            _logger = logger;
            this.context=context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Anasayfa()
        {
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