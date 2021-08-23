using Microsoft.AspNetCore.Mvc;
using Task_3_Controller_IP_Address.Models;

namespace Task_3_Controller_IP_Address.Controllers
{
    public class WebController : Controller
    {
        public IActionResult Index()
        {
            Ipaddress ipaddress = new Ipaddress();
            return View(ipaddress);
        }
    }
}
