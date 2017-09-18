using MadplanVbkAsp.Dtos;
using MadplanVbkAsp.Extensions;
using MadplanVbkAsp.Interfaces;
using MadplanVbkAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MadplanVbkAsp.Pages.Recipe
{
    public class CreateRecipeModel : PageModel
    {
        private bool _createNewRecipe;

        [BindProperty]
        public SharedLib.Models.Recipe Recipe { get; set; }

        public CreateRecipeModel()
        {

        }

        public void OnGet(bool createNewRecipe)
        {
            _createNewRecipe = createNewRecipe;

            // Opret Recipe hvis den ikke findes
            if (HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe) == null)
            {
                var recipe = new SharedLib.Models.Recipe(true);
                Recipe = recipe;
                HttpContext.Session.SetObjectAsJson(RecipeSessions.Recipe, recipe);

                var test = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);
            }
            else
            {
                // Hvis _createNewRecipe er true, overskriv den eksisterende med en ny recipe
                if (createNewRecipe == true)
                {
                    var recipe = new SharedLib.Models.Recipe(true);
                    Recipe = recipe;
                    HttpContext.Session.SetObjectAsJson(RecipeSessions.Recipe, recipe);
                }
                else
                {
                    Recipe = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);
                }
            }
        }

        public ActionResult OnPostAdd()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var recipe = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);

            // Gem den opdateret Recipe som Cache.
            HttpContext.Session.SetObjectAsJson(RecipeSessions.Recipe, recipe);

            return RedirectToPage("/Recipe/IngredientSelector");
        }
    }
}