using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Models
{
    public class MealType
    {
        // Singleton
        public static MealType Current = new MealType();

        public const string Breakfast = "Morgenmad";
        public const string Snack = "Mellemmåltid";
        public const string Lunch = "Frokost";
        public const string Dinner = "Aftensmad";
        public const string FirstSnack = "Første mellemmåltid";
        public const string SecondSnack = "Andet mellemmåltid";

        public List<string> ListOfMealTypes { get; set; }

        public MealType()
        {
            ListOfMealTypes = new List<string>()
            {
                Breakfast,
                Snack,
                Lunch,
                Dinner
            };
        }
    }
}
