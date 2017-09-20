using MadplanVbkAsp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SharedLib.Models;
using System.Linq;

namespace MadplanVbkAsp.Pages.Recipe
{
    public class IngredientSelectorModel : PageModel
    {
        private List<SharedLib.Models.Food> _completeList;

        public List<SharedLib.Models.Food> Foods { get; set; }

        [BindProperty]
        public string SearchText { get; set; }

        public IngredientSelectorModel(IFoodData foodData)
        {
            _completeList = foodData.GetAll();
        }

        public void OnGet()
        {
            Foods = getSeachResult(SearchText);
        }

        public ActionResult OnPostSearch(string searchText)
        {
            Foods = getSeachResult(SearchText);

            return Page();
        }

        private List<SharedLib.Models.Food> getSeachResult(string SearchText = null)
        {
            if (string.IsNullOrWhiteSpace(SearchText))
                return _completeList.OrderBy(a => a.Name, StringComparer.Ordinal).ToList();

            return _completeList.Where(a => a.Name.ToLowerInvariant().Contains(SearchText.ToLowerInvariant())).OrderBy(b => b.Name).ToList();
        }
    }

    
}