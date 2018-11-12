using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http; 
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/about")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        [HttpGet]
        [Route("/resume")]
        public IActionResult Resume()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpGet]
        [Route("/projects")]
        public IActionResult Projects()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpGet]
        [Route("/contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        
        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
