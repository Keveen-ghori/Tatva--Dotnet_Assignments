using FirstApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstApplication.Controllers
{
    
    public class HomeController : Controller
    {

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("Home/Landing")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("Home/Volunteer")]
        public IActionResult Volunteer()
        {
            return View();
        }

        [Route("Home/Story")]
        public IActionResult Story()
        {
            return View();
        }

    }
}