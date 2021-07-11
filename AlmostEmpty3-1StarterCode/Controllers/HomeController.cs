using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlmostEmpty3_1StarterCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Title = "Home";  setting a title via ViewBag.element = "Name";
            ViewData["Title"] = "Home"; //way #2 for Views
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About"; //way #2 for Views
            return View();
        }
    }
}
