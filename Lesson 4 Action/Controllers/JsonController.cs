using Microsoft.AspNetCore.Mvc;
using Lesson_4_Action.Models;
using System.Collections.Generic;

namespace Lesson_4_Action.Controllers
{
    public class JsonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutClient()
        {
            var client = new Client()
            {
                id = 1,
                name = "Alex",
                email = "alex@gmail.com"
            };

            return Json(client);
        }

        public IActionResult AboutClient2()
        {
            return Json(new Client()
            {
                id = 1,
                name = "Alex",
                email = "alex@gmail.com"
            }); 
        }

        public IActionResult AboutClients()
        {
            List<Client> list = new List<Client>();
            for (int i = 0; i < 3; i++)
            {
                list.Add(new Client { 
                    id = i, name = "user " + i, email = "user" + i + "@gmail.com"
                });
            }


            return Json(list);
        }
    }
}
