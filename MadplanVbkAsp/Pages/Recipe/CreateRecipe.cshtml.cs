using MadplanVbkAsp.Data;
using MadplanVbkAsp.Extensions;
using MadplanVbkAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SharedLib.Models;

namespace MadplanVbkAsp.Pages.Recipe
{
    public class CreateRecipeModel : PageModel
    {
        private bool _createNewRecipe;
        private MongoDbContext _dbContext;

        [BindProperty]
        public SharedLib.Models.Recipe Recipe { get; set; }

        public SelectList ListOfMealTypes { get; set; }

        public CreateRecipeModel(MongoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet(bool createNewRecipe)
        {
            _createNewRecipe = createNewRecipe;

            // Opret Recipe hvis den ikke findes
            if (HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe) == null)
            {
                var recipe = new SharedLib.Models.Recipe();
                Recipe = recipe;
                HttpContext.Session.SetObjectAsJson(RecipeSessions.Recipe, recipe);
            }
            else
            {
                // Hvis _createNewRecipe er true, overskriv den eksisterende med en ny recipe
                if (createNewRecipe == true)
                {
                    var recipe = new SharedLib.Models.Recipe();
                    Recipe = recipe;
                    HttpContext.Session.SetObjectAsJson(RecipeSessions.Recipe, recipe);
                }
                else
                {
                    Recipe = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);
                }
            }

            ListOfMealTypes = new SelectList(MealType.Current.ListOfMealTypes);
        }

        public ActionResult OnPostAdd()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var recipe = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);

            // TODO: Mangler at name er required.
            recipe.Name = Recipe.Name;
            recipe.Type = Recipe.Type;

            // Gem den opdateret Recipe som Cache.
            HttpContext.Session.SetObjectAsJson(RecipeSessions.Recipe, recipe);

            return RedirectToPage("/Recipe/IngredientSelector");
        }

        public ActionResult OnPostSaveRecipe()
        {
            if (HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe) == null)
            {
                return Page();
            }

            var recipe = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);

            // TODO: Mangler at name er required.
            recipe.Name = Recipe.Name;
            recipe.Type = Recipe.Type;

            _dbContext.Recipes.InsertOne(recipe);

            return RedirectToPage("./Index");
        }

        public ActionResult OnPostClearRecipe()
        {
            return Page();
        }
    }
}