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
        public List<SharedLib.Models.Food> Foods { get; set; }

        public IndexModel(IFoodData foodData)
        {
            Foods = foodData.GetAll();
        }

        public void OnGet()
        {

        }
    }
}