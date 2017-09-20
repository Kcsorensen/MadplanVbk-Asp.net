using MadplanVbkAsp.Data;
using MadplanVbkAsp.Extensions;
using MadplanVbkAsp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Driver;
using SharedLib.Models;
using System;
using System.Threading.Tasks;

namespace MadplanVbkAsp.Pages.Recipe
{
    public class IngredientFormModel : PageModel
    {
        private MongoDbContext _dbContext;

        [BindProperty]
        public Ingredient Ingredient { get; set; }

        public SelectList ListOfQuantityTypes { get; set; }

        public IngredientFormModel(MongoDbContext dbContext)
        {
            _dbContext = dbContext;

            ListOfQuantityTypes = new SelectList(QuantityType.Current.CompleteListOfQuantityTypes);
        }

        public async Task OnGetAsync(Guid id)
        {
            var food = await _dbContext.Foods.Find(a => a.Id == id).SingleAsync();

            var ingredient = new Ingredient(food);
            Ingredient = ingredient;
            HttpContext.Session.SetObjectAsJson(RecipeSessions.Ingredient, ingredient);
        }

        public ActionResult OnPostAddIngredient()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (HttpContext.Session.GetObjectFromJson<Ingredient>(RecipeSessions.Ingredient) == null)
            {
                return Page();
            }

            var ingredient = HttpContext.Session.GetObjectFromJson<Ingredient>(RecipeSessions.Ingredient);

            ingredient.Quantity = Ingredient.Quantity;
            ingredient.QuantityType = Ingredient.QuantityType;

            var recipe = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);

            recipe.Ingredients.Add(ingredient);

            // Gem den opdateret recipe.
            HttpContext.Session.SetObjectAsJson(RecipeSessions.Recipe, recipe);

            return RedirectToPage("./CreateRecipe", new { createNewRecipe = false });
        }
    }
}