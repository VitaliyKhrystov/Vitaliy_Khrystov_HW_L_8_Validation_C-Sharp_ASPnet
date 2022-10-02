using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task_3.Models;

namespace Task_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string data)
        {
            return View((object)data);
        }

    }
}