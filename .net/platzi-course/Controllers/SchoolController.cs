using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using platzi_course.Models;

namespace platzi_course.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public SchoolController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var school = new School();
            school.UniqueId=Guid.NewGuid().ToString();
            school.CreationDate=2005;
            school.Name= "Platzy School";
            school.City= "Medellin";
            school.Country = "Colombia";
            school.Address = "LA";

            ViewBag.Test="test";
            return View(school);
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
