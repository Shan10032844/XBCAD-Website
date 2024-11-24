using Microsoft.AspNetCore.Mvc;
using SCHOOL.Models;
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

namespace SCHOOL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}

