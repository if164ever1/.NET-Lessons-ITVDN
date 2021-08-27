using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using Lesson1.Models;
using Microsoft.AspNetCore.Hosting;

namespace Lesson1
{
    public class ProductsController : Controller
    {

        private ProducrReader reader;
        private readonly IWebHostEnvironment environment;

        public ProductsController(IWebHostEnvironment env)
        {
            reader = new ProducrReader();
            environment = env;
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

        public IActionResult GetFile()
        {
            return PhysicalFile(environment.ContentRootPath + @"/App_Data/data.txt", "text/plain", "downloaded_file.txt");
        }
    }
}
