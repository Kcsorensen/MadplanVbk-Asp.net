using MadplanVbkAsp.Data;
using MadplanVbkAsp.Dtos;
using MadplanVbkAsp.Extensions;
using MadplanVbkAsp.Interfaces;
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
        private IRecipeDto _recipeDto;

        [BindProperty]
        public IngredientDto IngredientDto { get; set; }

        public SelectList ListOfQuantityTypes { get; set; }

        public IngredientFormModel(MongoDbContext dbContext, IRecipeDto recipeDto)
        {
            _dbContext = dbContext;
            _recipeDto = recipeDto;
            IngredientDto = new IngredientDto() { QuantityType = QuantityType.gram };

            ListOfQuantityTypes = new SelectList(QuantityType.Current.CompleteListOfQuantityTypes);
        }

        public async Task OnGetAsync(Guid id)
        {
            var food = await _dbContext.Foods.Find(a => a.Id == id).SingleAsync();

            if (HttpContext.Session.GetObjectFromJson<Ingredient>(RecipeSessions.RecipeData) == null)
            {
                var ingredient = new Ingredient(food);

                HttpContext.Session.SetObjectAsJson(RecipeSessions.RecipeData, ingredient);
            }

            IngredientDto.Name = food.Name;

        }

        public ActionResult OnPostAddIngredient()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (HttpContext.Session.GetObjectFromJson<Ingredient>(RecipeSessions.RecipeData) == null)
            {
                return Page();
            }

            var ingredient = HttpContext.Session.GetObjectFromJson<Ingredient>(RecipeSessions.RecipeData);

            ingredient.Quantity = IngredientDto.Quantity;
            ingredient.QuantityType = IngredientDto.QuantityType;

            _recipeDto.Recipe.Ingredients.Add(ingredient);

            return RedirectToPage("./CreateRecipe");
        }
    }
}