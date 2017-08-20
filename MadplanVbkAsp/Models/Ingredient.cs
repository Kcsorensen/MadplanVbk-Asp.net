using MadplanVbkAsp.Extensions;

namespace MadplanVbkAsp.Models
{
    public class Ingredient : BaseModel
    {
        public double Quantity { get; set; }
        public double QuantityType { get; set; }

        public bool QuantityVisible { get; set; }
        public bool BasicRecipe { get; set; }
        public bool ShoppingListChecked { get; set; }

        public int FoodId { get; set; }
    }
}
