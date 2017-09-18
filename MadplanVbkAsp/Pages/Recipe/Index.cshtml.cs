using MadplanVbkAsp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace MadplanVbkAsp.Pages.Recipe
{
    public class IndexModel : PageModel
    {
        public List<SharedLib.Models.Recipe> Recipes { get; set; }

        public IndexModel(IRecipeData recipeData)
        {
            Recipes = recipeData.GetAll();
        }

        public void OnGet()
        {

        }


        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/Recipe/CreateRecipe", new { createNewRecipe = true });
        }
    }
}