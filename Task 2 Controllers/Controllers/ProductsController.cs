using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_2_Controllers.Models;

namespace Task_2_Controllers.Controllers
{
    public class ProductsController : Controller
    {
        
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                Product product = new Product();
                products.Add(product);
            }

            ViewBag.Data = products;
            return View();
        }
        public IActionResult IndexModel()
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                Product product = new Product();
                products.Add(product);
            }
            return View(products);
        }
    }
}
