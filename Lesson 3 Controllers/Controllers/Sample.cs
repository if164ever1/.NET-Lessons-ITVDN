using Microsoft.AspNetCore.Mvc;
using System;
using Lesson_3_Controllers.Models;

namespace Lesson_3_Controllers.Controllers
{
    public class Sample : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sample1()
        {
            ViewData["text"] = "String from database";
            ViewData["date"] = DateTime.Now;
            return View("Sample1");
        }
        public IActionResult Sample2() 
        {
            ViewBag.Text = "String from Database";
            ViewBag.Date = DateTime.Now;
            return View("Sample2");
        }
        public IActionResult Sample3()
        {
            Data data = new Data() { Text = "String from database", Date = DateTime.Now };
            return View("Sample3", data);
        }
        public IActionResult Sample4()
        {
            Data data = new Data() { Text = "String from database", Date = DateTime.Now };
            return View("Sample3", data);
        }
    }
}
