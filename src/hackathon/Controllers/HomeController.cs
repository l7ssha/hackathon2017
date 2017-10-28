﻿using System.Linq;
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
            System.Console.WriteLine(vm.Typ + " " + vm.Rodzaj);

            if(vm.Rodzaj == "Przedszkole")
            {
                if(vm.Typ == "Publiczna" || vm.Rodzaj == "Prywatna")
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
                if(vm.Typ == "Publiczna" || vm.Rodzaj == "Prywatna")
                {
                    var result = _db.SzkolyPodstawowe.Where(x=> x.prywatna == int.Parse(vm.Typ)).ToList();
                    return View(nameof(SearchResult), result);
                }
                else
                {
                    var result = _db.Przedszkola.ToList();
                    return View(nameof(SearchResult), result);
                }
            }
            else if(vm.Rodzaj == "Srednia")
            {
                if(vm.Typ == "Publiczna" || vm.Rodzaj == "Prywatna")
                {
                    var result = _db.SzkolyPodstawowe.Where(x=> x.prywatna == int.Parse(vm.Typ)).ToList();
                    return View(nameof(SearchResult), result);
                }
                else
                {
                    var result = _db.Przedszkola.ToList();
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