using CI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CI.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("/")]
        [Route("/Home")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

       
    }
}