using Lesson_2._Routing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_2._Routing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(int x, int y)
        {
            int result = x + y;
            return View(result);
        }
        public IActionResult Mul(int x, int y)
        {
            int result = x * y;
            return View(result);
        }
        public IActionResult Div(int x, int y)
        {
            int result = x / y;
            return View(result);
        }
        public IActionResult Sub(int x, int y)
        {
            int result = x - y;
            return View(result);
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
