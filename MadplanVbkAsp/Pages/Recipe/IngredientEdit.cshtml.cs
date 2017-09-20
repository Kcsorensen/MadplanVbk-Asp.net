using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MadplanVbkAsp.Extensions;
using MadplanVbkAsp.Models;
using SharedLib.Models;
using MadplanVbkAsp.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MadplanVbkAsp.Pages.Recipe
{
    public class IngredientEditModel : PageModel
    {
        [BindProperty]
        public IngredientDto IngredientDto { get; set; }

        public SelectList ListOfQuantityTypes { get; set; }

        public IngredientEditModel()
        {
            ListOfQuantityTypes = new SelectList(QuantityType.Current.CompleteListOfQuantityTypes);
            IngredientDto = new IngredientDto();
        }

        public void OnGet(Guid id)
        {
            var recipe = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);
            var selectedIngredient = recipe.Ingredients.Single(a => a.Id == id);

            IngredientDto.Id = selectedIngredient.Id;
            IngredientDto.Name = selectedIngredient.Food.Name;
            IngredientDto.Quantity = selectedIngredient.Quantity;
            IngredientDto.QuantityType = selectedIngredient.QuantityType;
        }

        public ActionResult OnPostEditIngredient()
        {
            var recipe = HttpContext.Session.GetObjectFromJson<SharedLib.Models.Recipe>(RecipeSessions.Recipe);
            var selectedIngredient = recipe.Ingredients.Single(a => a.Id == IngredientDto.Id);

            selectedIngredient.Quantity = IngredientDto.Quantity;
            selectedIngredient.QuantityType = IngredientDto.QuantityType;

            HttpContext.Session.SetObjectAsJson(RecipeSessions.Recipe, recipe);

            return RedirectToPage("./CreateRecipe", new { createNewRecipe = false });
        }

    }
}