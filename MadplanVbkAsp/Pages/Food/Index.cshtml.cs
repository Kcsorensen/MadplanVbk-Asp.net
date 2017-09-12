using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MadplanVbkAsp.Interfaces;
using SharedLib.Models;

namespace MadplanVbkAsp.Pages.Food
{
    public class IndexModel : PageModel
    {
        public List<Recipe> Recipes { get; set; }

        public IndexModel(IRecipeData recipeData)
        {
            Recipes = recipeData.GetAll();
        }

        public void OnGet()
        {

        }
    }
}