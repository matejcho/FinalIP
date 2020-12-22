using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalIP.Models;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace FinalIP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calculation()
        {
            return View();
        }
        public IActionResult Read()
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Exam.txt");

            string SendData = System.IO.File.ReadAllText(file);
            ViewBag.text = SendData;
            return View();
        }
        public IActionResult MyId()
        {
            string myId = "My Full Name is : Matej Gjozinski and my ID is: 4200";
            ViewBag.myid = myId;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
