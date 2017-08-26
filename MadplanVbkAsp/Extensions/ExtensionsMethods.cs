using CsvHelper;
using MadplanVbkAsp.Data;
using MongoDB.Driver;
using SharedLib.Models;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

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

        //#region String to Double Converter

        //public static double ConvertToDouble(this string stringVal)
        //{
        //    var doubleVal = double.NaN;

        //    if (!string.IsNullOrWhiteSpace(stringVal))
        //    {
        //        doubleVal = Convert.ToDouble(stringVal, new CultureInfo("da-DK"));
        //    }

        //    return doubleVal;
        //}

        //public static double ToDouble(this string stringVal)
        //{
        //    var doubleVal = double.NaN;

        //    if (!string.IsNullOrWhiteSpace(stringVal))
        //    {
        //        doubleVal = Convert.ToDouble(stringVal);
        //    }

        //    return doubleVal;
        //}

        //#endregion

        public static void EnsureSeedData(this MongoDbContext context)
        {
            MongoDbContext dbContext = new MongoDbContext();


            //var recipes = dbContext.Recipes.Find(a => true).ToList();

            //var food = dbContext.Foods.Find(a => true).ToList();

            //var test = from r in recipes.First().Ingredients
            //           join f in food on r.FoodId equals f.Id
            //           select new { r, f };

            //var test2 = from r in recipes.First().Ingredients
            //            from f in food
            //            where r.FoodId == f.Id
            //            select 
        }
    }
}
