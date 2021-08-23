using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Task_3_Controller_Calculator.Models;

namespace Task_3_Controller_Calculator.Controllers
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

        public IActionResult Calculate(string a, string b, string submitButton)
        {
            string result = "";
            int first = Convert.ToInt32(a);
            int second = Convert.ToInt32(b);
            switch (submitButton) 
            {
                case "Plus": {
                        int res = first + second;
                        return View(res);
                    }
                case "Sub":
                    {
                        int res = first - second;
                        return View(res);
                    }
                case "Mult":
                    {
                        int res = first * second;
                        return View(res);
                    }
                case "Div":
                    {
                        int res = first / second;
                        return View(res);
                    }
            }
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
