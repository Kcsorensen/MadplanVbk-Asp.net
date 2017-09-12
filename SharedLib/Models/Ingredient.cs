using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Models
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public Food Food { get; set; }
        public double Quantity { get; set; }
        public string QuantityType { get; set; }
        public string DefaultQuantityType { get; set; }

        public bool QuantityVisible { get; set; }
        public bool BasicRecipe { get; set; }
        public bool ShoppingListChecked { get; set; }

        public Ingredient()
        {
            Id = Guid.NewGuid();
            QuantityVisible = true;
            BasicRecipe = false;
            ShoppingListChecked = false;
            DefaultQuantityType = SharedLib.Models.QuantityType.gram;
        }

        public Ingredient(Food food)
        {
            Id = Guid.NewGuid();
            Food = food;
            QuantityVisible = true;
            BasicRecipe = false;
            ShoppingListChecked = false;
            DefaultQuantityType = SharedLib.Models.QuantityType.gram;
            QuantityType = DefaultQuantityType;
        }
    }
}
