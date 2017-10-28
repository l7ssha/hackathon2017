using System.Linq;
using Microsoft.AspNetCore.Mvc;
using hackathon.Models;
using hackathon.ViewModels;

namespace hackathon.Controllers
{
    public class HomeController : Controller
    {
        private readonly SzkolyNysaContext _db;

        public HomeController(SzkolyNysaContext db) 
            => _db = db;

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(SearchViewModel vm)
        {
            return View();
        }

        public IActionResult Ranking()
        {
            return View();
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