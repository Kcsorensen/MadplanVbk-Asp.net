using SharedLib.Models;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace MadplanVbkAsp.Dtos
{
    public class RecipeDto 
    {
        [Required]
        [Display(Name="navn")]
        public string Name { get; set; }

        [Required]
        public string MealType { get; set; }

        public ObservableCollection<Ingredient> Ingredients { get; set; }

        public RecipeDto()
        {
            MealType = SharedLib.Models.MealType.Breakfast;
            Ingredients = new ObservableCollection<Ingredient>();
        }

    }
}
