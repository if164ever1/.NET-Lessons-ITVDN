using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_3_Controllers.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(string message)
        {
            ViewBag.Text = message;
            return View("Index");
        }
        public IActionResult Catalog(string id)
        {
            ViewBag.Text = id;
            return View("Index");
        }
        public IActionResult Users(string id)
        {
            ViewBag.Text = id;
            return View("Index");
        }
    }
}
