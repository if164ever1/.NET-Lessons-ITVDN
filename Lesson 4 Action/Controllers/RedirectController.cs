using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_4_Action.Controllers
{
    public class RedirectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sample1()
        {
            return Redirect("http://google.com.ua");
        }
        public IActionResult Sample2()
        {
            return Redirect("/home/index");
        }

        public IActionResult Sample3()
        {
            return RedirectPermanent("/home/index");
        }

        public IActionResult Sample4()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Sample5()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Sample6()
        {
            return RedirectToRoute(new { Action = "Index", Controller = "Home" });
        }
    }
}
