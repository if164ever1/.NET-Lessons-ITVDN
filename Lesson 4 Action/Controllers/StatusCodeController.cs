using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_4_Action.Controllers
{
    public class StatusCodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Sample1()
        {
            return StatusCode(200);
        }
        public IActionResult Sample2() => Ok();

        public IActionResult Sample3()
        {
            return Created(Request.Path + "/123", new { one = "1", two = "2" });
        }
        
        public IActionResult Sample4()
        {
            return BadRequest();
        }
        
        public IActionResult Sample5()
        {
            return Unauthorized();
        }
        
        public IActionResult Sample6()
        {
            return NotFound();
        }
    }
}
