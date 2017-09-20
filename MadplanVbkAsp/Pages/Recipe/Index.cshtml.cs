using MadplanVbkAsp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MadplanVbkAsp.Pages.Recipe
{
    public class IndexModel : PageModel
    {
        private IRecipeData _recipeData;

        public List<SharedLib.Models.Recipe> Recipes { get; set; }

        public IndexModel(IRecipeData recipeData)
        {
            _recipeData = recipeData;
        }

        public void OnGet()
        {
            Recipes = _recipeData.GetAll().OrderBy(a => a.Name, StringComparer.Ordinal).ToList();
        }

        public ActionResult OnPostCreateRecipe()
        {
            return RedirectToPage("/Recipe/CreateRecipe", new { createNewRecipe = true });
        }

        public ActionResult OnPostDeleteRecipe(Guid id)
        {
            _recipeData.Remove(id);

            return RedirectToPage("./Index");
        }
    }
}