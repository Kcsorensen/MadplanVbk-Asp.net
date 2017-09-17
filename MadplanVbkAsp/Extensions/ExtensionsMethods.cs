using MadplanVbkAsp.Data;
using Microsoft.AspNetCore.Http;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

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

        #region Session Extensions

        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            // This setting is necessary to correct serialize of derived classes
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            var serialize = JsonConvert.SerializeObject(value, settings);

            session.SetString(key, serialize);
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            // This setting is necessary to correct deserialize of derived classes
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            var value = session.GetString(key);

            if (value == null)
            {
                return default(T);
            }

            var deserialize = JsonConvert.DeserializeObject<T>(value, settings);

            return deserialize;
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
            #region Initialize Db

            //IFoodData foodData = new FoodData();
            //foodData.GetAll();

            //IRecipeData recipeData = new RecipeData();
            //recipeData.GetAll();

            #endregion

            //var dbContext = new MongoDbContext();

            //var col = dbContext.Testings.Find(a => true).ToList();



            //foreach (var item in col)
            //{
            //    var filter = Builders<Testing>.Filter.Eq("Id", item.Id);
            //    var update = Builders<Testing>.Update.Set("Money", 100);
            //    dbContext.Testings.UpdateOne(filter, update);
            //}


            //var recipes = dbContext.Recipes;

            //var Egg = dbContext.Foods.Find(a => a.FoodId == 1159).First();

            //Egg.Name = "Testing æg";

            //var filter = Builders<Recipe>.Filter;
            //var test = filter.ElemMatch(r => r.Ingredients, i => i.Food.Id == Egg.Id);
            //var recipe = recipes.Find(test).SingleOrDefault();

            //var update = Builders<Recipe>.Update;

            //var setter = update.Set(r => r.Ingredients[-1].Food, Egg);

            //recipes.UpdateOne(test, setter);

            //foreach (var recipe in recipes)
            //{
            //    if (recipe.Ingredients.Any(a => a.Food.Id == Egg.Id))
            //    {
            //        var filter = Builders<Recipe>.Filter.Where(a =

            //        var ingredient = recipe.Ingredients.Where(a => a.Food.Id == Egg.Id).First();



            //        recipe.Ingredients.Remove(ingredient);

            //        ingredient.Food = Egg;

            //        recipe.Ingredients.Add(ingredient);

            //        //dbContext.Recipes.ReplaceOne()

            //    } 

            //}

            //var test = Builders<Recipe>.Filter.Where(a => a.Ingredients.Where(b => b.Food.Id == Egg.Id))


        }
    }
}
