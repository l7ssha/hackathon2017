using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hackathon.Models;
using Microsoft.EntityFrameworkCore;

namespace hackathon.Controllers
{
    public class HomeController : Controller
    {
        private readonly SzkolyNysaContext _db;

        public HomeController(SzkolyNysaContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var szkoly = _db.SzkolyPodstawowe.FirstOrDefault();

            return View(szkoly);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}
