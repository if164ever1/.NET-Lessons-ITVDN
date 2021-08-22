using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

using Lesson1.Models;


namespace Lesson1
{
    public class ProductsController : Controller
    {

        private ProducrReader reader;

        public ProductsController()
        {
            reader = new ProducrReader();
        }

        public IActionResult List()
        {
            List<Product> products = reader.ReadFromFile();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            List<Product> products = reader.ReadFromFile();
            Product product = products.Where(x => x.Id == id).FirstOrDefault();
            return (product != null) ? View(product) : NotFound();
        }

        public IActionResult Category(int id)
        {
            
            List<Product> products = reader.ReadFromFile();
            List<Product> category = new List<Product>();
            string cat = products.SingleOrDefault(obj => obj.Id == id)?.Category;
            foreach (Product value in products.Where(x => x.Category == cat))
            {
                category.Add(value);
            }

            return View(category);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
