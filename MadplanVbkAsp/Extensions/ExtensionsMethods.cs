using MadplanVbkAsp.Data;
using MadplanVbkAsp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace MadplanVbkAsp.Extensions
{
    public static class ExtensionsMethods
    {
        #region EnumHelper

        public static string Description(this Enum value)
        {
            // get attributes  
            var field = value.GetType().GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            // return description
            return attributes.Any() ? ((DescriptionAttribute)attributes.ElementAt(0)).Description : "Description Not Found";
        }

        #endregion

        #region String to Double Converter

        public static double ConvertToDouble(this string stringVal)
        {
            var doubleVal = double.NaN;

            if (!string.IsNullOrWhiteSpace(stringVal))
            {
                doubleVal = Convert.ToDouble(stringVal, new CultureInfo("da-DK"));
            }

            return doubleVal;
        }

        public static double ToDouble(this string stringVal)
        {
            var doubleVal = double.NaN;

            if (!string.IsNullOrWhiteSpace(stringVal))
            {
                doubleVal = Convert.ToDouble(stringVal);
            }

            return doubleVal;
        }

        #endregion

        public static void EnsureSeedData(this SqlDbContext context)
        {
            // Evt
            if (!context.Foods.Any())
            {

            }

            context.Foods.Add(new Food
            {
                Name = "test",
                QuantityConverter = new QuantityConverter
                {
                    Quantities = new List<Quantity>
                        {
                            new Quantity{ Name = QuantityType.dl, Value = 2},
                            new Quantity{ Name = QuantityType.dråbe, Value = 1},
                            new Quantity{ Name = QuantityType.gram, Value = 0.5},
                            new Quantity{ Name = QuantityType.pakke, Value = 0.25},
                        }
                },

            });

            context.Foods.Add(new Food
            {
                Name = "test2",
                QuantityConverter = new QuantityConverter
                {
                    Quantities = new List<Quantity>
                        {
                            new Quantity{ Name = QuantityType.dl, Value = 2},
                            new Quantity{ Name = QuantityType.dråbe, Value = 1},
                            new Quantity{ Name = QuantityType.gram, Value = 0.5},
                            new Quantity{ Name = QuantityType.pakke, Value = 0.25},
                        }
                },

            });

            context.SaveChanges();
        }

    }
}
