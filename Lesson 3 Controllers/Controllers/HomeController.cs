using Lesson_3_Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Lesson_3_Controllers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Result() => View("Result", "Hello from Result");
        public ViewResult Index()=> View();
        public ViewResult Test() => new ViewResult()
        {
            ViewName = "Test",
            ViewData = new ViewDataDictionary(
            new EmptyModelMetadataProvider(), 
            new ModelStateDictionary())
            {
                Model = "Hello from Test"
            }
        };

        public IActionResult SendExample()
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
