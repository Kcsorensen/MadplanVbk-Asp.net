using MadplanVbkAsp.Dtos;
using MadplanVbkAsp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MadplanVbkAsp.Pages.Recipe
{
    public class CreateRecipeModel : PageModel
    {
        private IRecipeDto _recipeDto;

        [BindProperty]
        public SharedLib.Models.Recipe Recipe { get; set; }

        public CreateRecipeModel(IRecipeDto recipeDto)
        {
            _recipeDto = recipeDto;
        }

        public void OnGet()
        {
            Recipe = _recipeDto.Recipe;
        }

        public ActionResult OnPostAdd()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _recipeDto.Recipe = Recipe;

            return RedirectToPage("/Recipe/IngredientSelector");
        }
    }
}