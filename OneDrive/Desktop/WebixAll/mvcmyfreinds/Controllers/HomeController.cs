using Microsoft.AspNetCore.Mvc;
using mvcmyfreinds.Models;
using System.Diagnostics;

namespace mvcmyfreinds.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private Friend friend = new Friend(1, "Moshe", 27);

        private Dog dog = new Dog(354, "Toky", 4);
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Friend()
        {
            return View(friend);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Dog()
        {
            return View(dog);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Profile()
        {
            return View();
        }

    }
}
