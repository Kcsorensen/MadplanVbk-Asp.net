using SharedLib.Models;
using System.Collections.Generic;

namespace MadplanVbkAsp.Interface
{
    public interface IRecipeData
    {
        IEnumerable<Recipe> GetAll();
        Recipe Get(int id);
        void Add(Recipe newRecipe);
    }
}
