using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace hackathon.ViewModels
{
    public class SearchViewModel
    {
        public string Rodzaj { get; set; }
        public string Typ { get; set; }
        public string Kierunek { get; set; }

        public List<SelectListItem> Items { get; set; }
        
    }
}