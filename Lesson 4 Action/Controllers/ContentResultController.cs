using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_4_Action.Controllers
{
    public class ContentResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sample1()
        {
            return Content("Hello world!", "text/palin");
        }

        public IActionResult Sample2()
        {
            return Content("[1,2,42]", "application/json");
        }
    }
}
