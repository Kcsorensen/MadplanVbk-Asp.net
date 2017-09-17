using MadplanVbkAsp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedLib.Models;
using System.Collections.ObjectModel;

namespace MadplanVbkAsp.Dtos
{
    public class RecipeDto : IRecipeDto
    {
        public Recipe Recipe { get; set; }

        public RecipeDto()
        {
            Recipe = new Recipe();
        }

        public void Clear()
        {
            Recipe = new Recipe();
        }

    }
}
