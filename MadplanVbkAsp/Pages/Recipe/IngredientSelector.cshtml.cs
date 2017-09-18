using MadplanVbkAsp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace MadplanVbkAsp.Pages.Recipe
{
    public class IngredientSelectorModel : PageModel
    {
        public List<SharedLib.Models.Food> Foods { get; set; }

        public IngredientSelectorModel(IFoodData foodData)
        {
            Foods = foodData.GetAll();
        }

        public void OnGet()
        {

        }
    }
}