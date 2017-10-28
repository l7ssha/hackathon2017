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

        public IActionResult Ranking()
        {
            return View();
        }

        public IActionResult Przedszkola()
        {
            var data = _db.Przedszkola.ToList();

            return View(data);
        }

        public IActionResult SzkolySrednie()
        {
            var data = _db.SzkolySrednie.ToList();
            return View(data);
        }

        public IActionResult SzkolyPodstawowe() 
        {
            var data = _db.SzkolyPodstawowe.ToList();
            return View(data);
        }


        public IActionResult Przedszkole(int i)
        {
            var przedsz = _db.Przedszkola.Single(x => x.Id == i);
            return View(przedsz);
        }

        public IActionResult SzkolaSrednia(int i)
        {
            var przedsz = _db.SzkolySrednie.Single(x => x.Id == i);
            return View(przedsz);
        }

        public IActionResult SzkolaPodstawowa(int i)
        {
            var przedsz = _db.SzkolyPodstawowe.Single(x => x.Id == i);
            return View(przedsz);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
