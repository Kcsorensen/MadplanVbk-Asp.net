using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Models
{
    public class Recipe
    {
        public const string Default = "Vælg måltid";

        public string Name { get; set; }
        public string Type { get; set; }
        public string DefaultQuantityType { get; set; }
        public double Ratio { get; set; }
        public double Persons { get; set; }
        public int Page { get; set; }
        public ObservableCollection<Ingredient> Ingredients { get; set; }

        public Recipe()
        {
            Type = "Vælg";
            DefaultQuantityType = QuantityType.gram;
            Ingredients = new ObservableCollection<Ingredient>();
        }
    }
}
