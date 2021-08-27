using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Lesson_4_Action.Controllers
{
    public class FileController : Controller
    {
        private readonly IWebHostEnvironment environment;

        public FileController(IWebHostEnvironment env)
        {
            environment = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sample1()
        {
            byte[] fileContent = System.IO.File.ReadAllBytes("App_data/document.pdf");

            return File(fileContent, "application/pdf", "Save pdf file.pdf");
        }

        public IActionResult Sample2()
        {
            FileStream fileStream = System.IO.File.OpenRead("App_data/document.pdf");

            return File(fileStream, "application/pdf");
        }
        
        public IActionResult Sample3()
        {
            return PhysicalFile(environment.ContentRootPath + @"\App_data\document.pdf", "application/pdf");
        }
    }
}
