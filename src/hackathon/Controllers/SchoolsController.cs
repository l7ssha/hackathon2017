using System.Linq;
using Microsoft.AspNetCore.Mvc;
using hackathon.Models;

namespace hackathon.Controllers
{
    public class SchoolsController : Controller
    {
        private readonly SzkolyNysaContext _db;

        public SchoolsController(SzkolyNysaContext db) 
            => _db = db;

        public IActionResult Index()
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
            var data = _db.SzkolySrednie.Where(x => x.Id < 10).ToList();
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

        public IActionResult Zlobki()
        {
            var data = _db.Zlobki.ToList();
            return View(data);
        }

        public IActionResult Zlobek(int i)
        {
            var data = _db.Zlobki.Single(x=> x.Id == i);
            return View(data);
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

        public IActionResult SzkolyWyzsze()
        {
            var szko = _db.SzkolySrednie.Single(x => x.Id == 10);
            return View(szko);
        }
    }
}