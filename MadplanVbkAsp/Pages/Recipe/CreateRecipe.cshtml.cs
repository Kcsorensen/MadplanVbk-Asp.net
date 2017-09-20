using MadplanVbkAsp.Data;
using MadplanVbkAsp.Dtos;
using MadplanVbkAsp.Extensions;
using MadplanVbkAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SharedLib.Models;
using System;
using System.Linq;

namespace MadplanVbkAsp.Pages.Recipe
{
    public class CreateRecipeModel : PageModel
    {
        private bool _createNewRecipe;
        private MongoDbContext _dbContext;

        [BindProperty]
        public RecipeDto RecipeDto { get; set; }

        public SelectList ListOfMealTypes { get; set; }

        public CreateRecipeModel(MongoDbContext dbContext)
        {
            _dbContext = dbContext;
            RecipeDto = new RecipeDto();

            ListOfMealTypes = new SelectList(MealType.Current.ListOfMealTypes);
        }

        public void OnGet(bool createNewRecipe)
        {
            _createNewRecipe = createNewRecipe;

            // Opret Recipe hvis den ikke findes
            if (HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe) == null)
            {
                var recipe = new SharedLib.Models.Recipe();

                RecipeDto.Name = recipe.Name;
                RecipeDto.MealType = recipe.Type;
                RecipeDto.Ingredients = recipe.Ingredients;

                HttpContext.Session.SetObjectAsJson(RecipeSessions.Recipe, recipe);
            }
            else
            {
                // Hvis _createNewRecipe er true, overskriv den eksisterende med en ny recipe
                if (createNewRecipe == true)
                {
                    var recipe = new SharedLib.Models.Recipe();

                    RecipeDto.Name = recipe.Name;
                    RecipeDto.MealType = recipe.Type;
                    RecipeDto.Ingredients = recipe.Ingredients;

                    HttpContext.Session.SetObjectAsJson(RecipeSessions.Recipe, recipe);
                }
                else
                {
                    var recipe = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);
                    RecipeDto.Name = recipe.Name;
                    RecipeDto.MealType = recipe.Type;
                    RecipeDto.Ingredients = recipe.Ingredients;
                }
            }
        }

        public ActionResult OnPostAdd()
        {
            var recipe = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);

            recipe.Name = RecipeDto.Name;
            recipe.Type = RecipeDto.MealType;

            // Gem den opdateret Recipe som Cache.
            HttpContext.Session.SetObjectAsJson(RecipeSessions.Recipe, recipe);

            return RedirectToPage("/Recipe/IngredientSelector");
        }

        public ActionResult OnPostSaveRecipe()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe) == null)
            {
                return Page();
            }

            var recipe = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);

            recipe.Name = RecipeDto.Name;
            recipe.Type = RecipeDto.MealType;

            _dbContext.Recipes.InsertOne(recipe);

            return RedirectToPage("./Index");
        }

        public ActionResult OnPostClearRecipe()
        {
            if (HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe) == null)
            {
                return Page();
            }

            var recipe = new SharedLib.Models.Recipe();

            RecipeDto.Name = recipe.Name;
            RecipeDto.MealType = recipe.Type;

            HttpContext.Session.SetObjectAsJson(RecipeSessions.Recipe, recipe);

            return Page();
        }

        public ActionResult OnPostDeleteIngredient(Guid id)
        {
            var recipe = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);

            var selectedIngredient = recipe.Ingredients.Single(a => a.Id == id);

            recipe.Ingredients.Remove(selectedIngredient);

            return Page();
        }
    }
}