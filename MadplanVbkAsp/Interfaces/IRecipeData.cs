using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadplanVbkAsp.Interfaces
{
    public interface IRecipeData
    {
        List<Recipe> GetAll();
        Recipe Get(int id);
        void Add(Recipe newRecipe);
    }
}
