using System.Linq;
using Microsoft.AspNetCore.Mvc;
using hackathon.Models;
using hackathon.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

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
            var model = new SearchViewModel();
            model.Items = new List<SelectListItem>();

            var kierunki = _db.SzkolySrednie.Select(x=> x.kierunki);

            return View();
        }

        [HttpPost]
        public IActionResult Search(SearchViewModel vm)
        {
            System.Console.WriteLine(vm.Typ + " " + vm.Rodzaj);

            if(vm.Rodzaj == "Przedszkole")
            {
                if(int.Parse(vm.Typ) != 3)
                {
                    var result = _db.Przedszkola.Where(x => x.prywatna == int.Parse(vm.Typ)).ToList();
                    return View(nameof(SearchResult), result);
                }
                else
                {
                    var result = _db.Przedszkola.ToList();
                    return View(nameof(SearchResult), result);
                }
            }
            else if(vm.Rodzaj == "Podstawowa")
            {
                if(int.Parse(vm.Typ) != 3)
                {
                    var result = _db.SzkolyPodstawowe.Where(x=> x.prywatna == int.Parse(vm.Typ)).ToList();
                    return View(nameof(SearchResult), result);
                }
                else
                {
                    var result = _db.SzkolyPodstawowe.ToList();
                    return View(nameof(SearchResult), result);
                }
            }
            else if(vm.Rodzaj == "Srednia")
            {
                if(int.Parse(vm.Typ) != 3)
                {
                    var result = _db.SzkolySrednie.Where(x=> x.prywatna == int.Parse(vm.Typ)).ToList();
                    return View(nameof(SearchResult), result);
                }
                else
                {
                    var result = _db.SzkolySrednie.ToList();
                    return View(nameof(SearchResult), result);
                }
            }
            else return RedirectToPage("Search");
        }

        public IActionResult SearchResult(IModel result)
        {
            return View(result);
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