using Microsoft.AspNetCore.Mvc;

using Lesson1.Models;

namespace Lesson1
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product() { Id = 1, name = "Test"};
            return View(product);
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
