﻿using MadplanVbkAsp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedLib.Models;
using MongoDB.Driver;
using System.Collections.ObjectModel;
using SharedLib.Extensions;

namespace MadplanVbkAsp.Data
{
    public class RecipeData : IRecipeData
    {
        private MongoDbContext dbContext = new MongoDbContext();

        public void Add(Recipe newRecipe)
        {
            throw new NotImplementedException();
        }

        public Recipe Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetAll()
        {
            if (dbContext.Recipes.Find(a => true).Count() == 0)
            {
                #region Morgenmad

                // Hvid æggepandekage med rød peber og ost
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Hvid æggepandekage med rød peber og ost",
                    Type = MealType.Breakfast,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 96,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.Friskæggehvide.GetDescription(), 2, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Havregryn.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Olivenolie.GetDescription(), 0, QuantityType.Ingen),
                    addFoodToRecipe(IngredientHelper.Peberfrugt.GetDescription(), 0.5, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.RevetOst.GetDescription(), 2, QuantityType.spsk),
                }
                });

                // Æggepandekage med skinke og ost
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Æggepandekage med skinke og ost",
                    Type = MealType.Breakfast,
                    Ratio = 0.7,
                    Persons = 1,
                    Page = 98,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 2, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Havregryn.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Olivenolie.GetDescription(), 0, QuantityType.Ingen),
                    addFoodToRecipe(IngredientHelper.SkinkePålæg.GetDescription(), 1, QuantityType.skive),
                    addFoodToRecipe(IngredientHelper.Tomat.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.RevetOst.GetDescription(), 2, QuantityType.spsk),
                }
                });

                // Skyr med Granola
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Skyr med Granola",
                    Type = MealType.Breakfast,
                    Ratio = 0.6,
                    Persons = 1,
                    Page = 100,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 1.5, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Granola.GetDescription(), 3, QuantityType.spsk, true),
                }
                });

                // Klapsammen med nøddespread og æg
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Klapsammen med nøddespread og æg",
                    Type = MealType.Breakfast,
                    Ratio = 0.3,
                    Persons = 1,
                    Page = 101,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.Rugbrød.GetDescription(), 1, QuantityType.skive),
                    addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Nøddepread.GetDescription(), 1, QuantityType.spsk, true),
                }
                });

                // Grovpita med skinke, gulerødder og hytteost
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Grovpita med skinke, gulerødder og hytteost",
                    Type = MealType.Breakfast,
                    Ratio = 0.6,
                    Persons = 1,
                    Page = 102,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.Pitabrød.GetDescription(), 1, QuantityType.skive),
                    addFoodToRecipe(IngredientHelper.Sennep.GetDescription(), 1, QuantityType.tsk),
                    addFoodToRecipe(IngredientHelper.SkinkePålæg.GetDescription(), 2, QuantityType.skive),
                    addFoodToRecipe(IngredientHelper.Gulerod.GetDescription(), 0.5, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Hytteost.GetDescription(), 3, QuantityType.spsk),
                }
                });

                // Ruggrød med æblemost og nødder
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Ruggrød med æblemost og nødder",
                    Type = MealType.Breakfast,
                    Ratio = 0.2,
                    Persons = 1,
                    Page = 104,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.Rugflager.GetDescription(), 1, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Æblemost.GetDescription(), 1, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Æble.GetDescription(), 0.5, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Hasselnødder.GetDescription(), 2, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Honning.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 2, QuantityType.spsk),
                }
                });

                // Knækbrød med æg og hytteost
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Knækbrød med æg og hytteost",
                    Type = MealType.Breakfast,
                    Ratio = 0.4,
                    Persons = 1,
                    Page = 106,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.Fuldkornsknækbrød.GetDescription(), 2, QuantityType.skive),
                    addFoodToRecipe(IngredientHelper.Agurk.GetDescription(), 6, QuantityType.skive),
                    addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Hytteost.GetDescription(), 2, QuantityType.spsk),
                }
                });

                // Pink grød med solbær
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Pink grød med solbær",
                    Type = MealType.Breakfast,
                    Ratio = 0.3,
                    Persons = 1,
                    Page = 108,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.Havregryn.GetDescription(), 1, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Solbærsaft.GetDescription(), 0.5, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Æble.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Rosiner.GetDescription(), 2, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 1, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
                }
                });

                // Grød "to go"
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Grød \"to go\"",
                    Type = MealType.Breakfast,
                    Ratio = 0.4,
                    Persons = 1,
                    Page = 110,
                    Ingredients = new ObservableCollection<Ingredient>()
                {

                    addFoodToRecipe(IngredientHelper.Mandler.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Chiafrø.GetDescription(), 1, QuantityType.tsk),
                    addFoodToRecipe(IngredientHelper.Rosiner.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Havregryn.GetDescription(), 0.75, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Kanel.GetDescription(), 1, QuantityType.knsp),
                    addFoodToRecipe(IngredientHelper.Honning.GetDescription(), 5, QuantityType.tsk),
                    addFoodToRecipe(IngredientHelper.Citronskal.GetDescription(), 1, QuantityType.tsk),
                    addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 1, QuantityType.spsk),
                }
                });

                // Syrnet mysli
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Syrnet mysli",
                    Type = MealType.Breakfast,
                    Ratio = 0.4,
                    Persons = 2,
                    Page = 112,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.Mælk.GetDescription(), 1, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Havregryn.GetDescription(), 2, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 1, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Rosiner.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Æble.GetDescription(), 1.5, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Bær.GetDescription(), 10, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Mandler.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Hasselnødder.GetDescription(), 1, QuantityType.spsk),
                }
                });

                // Søndag morgen
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Søndag morgen",
                    Type = MealType.Breakfast,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 114,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.Rugbrød.GetDescription(), 1, QuantityType.skive),
                    addFoodToRecipe(IngredientHelper.Hummus.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.SkinkePålæg.GetDescription(), 1, QuantityType.skive),
                    addFoodToRecipe(IngredientHelper.Æble.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 1, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Granola.GetDescription(), 1, QuantityType.spsk, true),
                }
                });

                #endregion

                #region Mellemmåltider

                // Rugbolle med chokolade

                // Gulerødder med grønne ærter
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Søndag morgen",
                    Type = MealType.Snack,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 120,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.TørrendeGrønneÆrter.GetDescription(), 1, QuantityType.dl),
                addFoodToRecipe(IngredientHelper.Rapsolie.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Hvidløg.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Spidskommen.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Græskarkerner.GetDescription(), 2, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Citron.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Gulerod.GetDescription(), 2, QuantityType.stk),
            }
                });

                // Røgbrød med AC-spread
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Røgbrød med AC-spread",
                    Type = MealType.Snack,
                    Ratio = 0.3,
                    Persons = 1,
                    Page = 122,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Rugbrød.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.ACspread.GetDescription(), 1, QuantityType.spsk, true),
            }
                });

                // Nøddespread på knækbrød
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Nøddespread på knækbrød",
                    Type = MealType.Snack,
                    Ratio = 0.2,
                    Persons = 1,
                    Page = 123,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Fuldkornsknækbrød.GetDescription(), 1, QuantityType.skive),
                addFoodToRecipe(IngredientHelper.Nøddepread.GetDescription(), 1, QuantityType.spsk, true),
            }
                });

                // Æg med knas
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Æg med knas",
                    Type = MealType.Snack,
                    Ratio = 1.9,
                    Persons = 1,
                    Page = 124,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Mandler.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Hasselnødder.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Græskarkerner.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Solsikkekerner.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
            }
                });

                // Æg med hytteost og mandler
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Æg med hytteost og mandler",
                    Type = MealType.Snack,
                    Ratio = 2.3,
                    Persons = 1,
                    Page = 126,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Hytteost.GetDescription(), 2, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Sennep.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Persille.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Mandler.GetDescription(), 2, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
            }
                });

                // Hytteost og æbler med fuldkornspitabrød
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Hytteost og æbler med fuldkornspitabrød",
                    Type = MealType.Snack,
                    Ratio = 0.3,
                    Persons = 1,
                    Page = 128,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Hytteost.GetDescription(), 2, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Æble.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Sesamfrø.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Pitabrød.GetDescription(), 1, QuantityType.spsk),
            }
                });

                // Æble med citron og kakaonibs
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Æble med citron og kakaonibs",
                    Type = MealType.Snack,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 130,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Æble.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Citron.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Hytteost.GetDescription(), 1, QuantityType.dl),
                addFoodToRecipe(IngredientHelper.Kakaonibs.GetDescription(), 1, QuantityType.tsk),
            }
                });

                // Pære med peber og mozzarella
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Pære med peber og mozzarella",
                    Type = MealType.Snack,
                    Ratio = 0.6,
                    Persons = 1,
                    Page = 132,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Pære.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Honning.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Mozzarella.GetDescription(), 0.5, QuantityType.stk),
            }
                });

                // Kiwi med knæk
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kiwi med knæk",
                    Type = MealType.Snack,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 133,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Mandler.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Græskarkerner.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Kiwi.GetDescription(), 1, QuantityType.stk),
            }
                });

                // Mango, mandler og mynte
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Mango, mandler og mynte",
                    Type = MealType.Snack,
                    Ratio = 0.1,
                    Persons = 1,
                    Page = 134,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Mango.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Mynte.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Mandler.GetDescription(), 10, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Æble.GetDescription(), 0.5, QuantityType.stk),
            }
                });


                #endregion

                #region Frokost

                // Fennikel, parmaskinke og mandler 
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Fennikel, parmaskinke og mandler",
                    Type = MealType.Lunch,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 138,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Fennikel.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Citron.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Honning.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Mandler.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Dild.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Rugbrød.GetDescription(), 1, QuantityType.skive),
                addFoodToRecipe(IngredientHelper.Parmaskinke.GetDescription(), 2, QuantityType.skive),
            }
                });

                // Korn, aguark, nødder og urter 
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Korn, aguark, nødder og urter",
                    Type = MealType.Lunch,
                    Ratio = 0.6,
                    Persons = 1,
                    Page = 140,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Rugkerner.GetDescription(), 50, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Agurk.GetDescription(), 0.25, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Hasselnødder.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Fishsauce.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Basilikum.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Skæreost.GetDescription(), 30, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Rapsolie.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Æbleeddike.GetDescription(), 1, QuantityType.spsk),
            }
                });

                // Kål, kød og ost
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kål, kød og ost",
                    Type = MealType.Lunch,
                    Ratio = 1.1,
                    Persons = 1,
                    Page = 142,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Kyllingbryst.GetDescription(), 100, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Sennep.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Citron.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Olivenolie.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Spidskål.GetDescription(), 100, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Emmentaler.GetDescription(), 30, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Honning.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Dild.GetDescription(), 0, QuantityType.Ingen),
            }
                });

                // Tun, kartofler og æg
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Tun, kartofler og æg",
                    Type = MealType.Lunch,
                    Ratio = 1.1,
                    Persons = 1,
                    Page = 144,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Tun.GetDescription(), 0.5, QuantityType.dåse),
                addFoodToRecipe(IngredientHelper.Radicchio.GetDescription(), 2, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Kartofler.GetDescription(), 4, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Drueagurker.GetDescription(), 2, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Olivenolie.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
            }
                });

                // Makrel, kål, rugbrød og skyr
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Makrel, kål, rugbrød og skyr",
                    Type = MealType.Lunch,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 146,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 2, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Sennep.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Spidskål.GetDescription(), 0.25, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Makrel.GetDescription(), 1, QuantityType.dåse),
                addFoodToRecipe(IngredientHelper.Mandler.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Dild.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Rugbrød.GetDescription(), 1, QuantityType.skive),
            }
                });

                // Korn, bær, hytteost
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Korn, bær, hytteost",
                    Type = MealType.Lunch,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 148,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Rugkerner.GetDescription(), 50, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Hytteost.GetDescription(), 1, QuantityType.dl),
                addFoodToRecipe(IngredientHelper.Dild.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Persille.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Citron.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Rapsolie.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Rosiner.GetDescription(), 1, QuantityType.spsk),
            }
                });

                // Kylling, majs og cornichoner
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kylling, majs og cornichoner",
                    Type = MealType.Lunch,
                    Ratio = 1.3,
                    Persons = 1,
                    Page = 149,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Kyllingbryst.GetDescription(), 100, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Oliven.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Cornichoner.GetDescription(), 3, QuantityType.skive),
                addFoodToRecipe(IngredientHelper.Majs.GetDescription(), 0.5, QuantityType.dåse),
                addFoodToRecipe(IngredientHelper.Tomat.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Olivenolie.GetDescription(), 0, QuantityType.Ingen),
            }
                });

                // Kold tomatsuppe
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kold tomatsuppe",
                    Type = MealType.Lunch,
                    Ratio = 0.3,
                    Persons = 1,
                    Page = 150,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.HakkedeTomater.GetDescription(), 1, QuantityType.dåse),
                addFoodToRecipe(IngredientHelper.Tomat.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Peberfrugt.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Agurk.GetDescription(), 0.25, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Chili.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Basilikum.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Hvidløg.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Tabasco.GetDescription(), 2, QuantityType.dråbe),
                addFoodToRecipe(IngredientHelper.Olivenolie.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Lime.GetDescription(), 1, QuantityType.tsk),
            }
                });

                // Wontonpakker med hummus og hytteost
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Wontonpakker med hummus og hytteost",
                    Type = MealType.Lunch,
                    Ratio = 0.4,
                    Persons = 1,
                    Page = 152,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Hummus.GetDescription(), 3, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Wontondej.GetDescription(), 1, QuantityType.pakke),
                addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Chiafrø.GetDescription(), 2, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Hytteost.GetDescription(), 3, QuantityType.tsk),
            }
                });

                // Rugbrød med torskerogn, sennepsskyr og karse
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Rugbrød med torskerogn, sennepsskyr og karse",
                    Type = MealType.Lunch,
                    Ratio = 0.4,
                    Persons = 1,
                    Page = 154,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Sennep.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Torskerogn.GetDescription(), 2, QuantityType.skive),
                addFoodToRecipe(IngredientHelper.Citron.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Radiser.GetDescription(), 2, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Karse.GetDescription(), 0, QuantityType.Ingen),
            }
                });

                // Amar´mad med hummus
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Amar´mad med hummus",
                    Type = MealType.Lunch,
                    Ratio = 0.3,
                    Persons = 1,
                    Page = 155,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Fuldkornsbrød.GetDescription(), 1, QuantityType.skive),
                addFoodToRecipe(IngredientHelper.Sennep.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Hummus.GetDescription(), 3, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Gulerod.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Rugbrød.GetDescription(), 1, QuantityType.skive),
            }
                });

                // Æggesalat på sprødt brød
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Æggesalat på sprødt brød",
                    Type = MealType.Lunch,
                    Ratio = 0.7,
                    Persons = 1,
                    Page = 156,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 1, QuantityType.dl),
                addFoodToRecipe(IngredientHelper.Karry.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Drueagurker.GetDescription(), 2, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Peberfrugt.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Blomkålsbuketter.GetDescription(), 2, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Rødløg.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 2, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Rugbrød.GetDescription(), 1, QuantityType.stk),
            }
                });

                #endregion

                #region Aftensmåltider

                // Wrap med kylling, kål og karry
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Korn, aguark, nødder og urter",
                    Type = MealType.Dinner,
                    Ratio = 1.0,
                    Persons = 1,
                    Page = 160,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Fuldkornswrap.GetDescription(), 50, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Spidskål.GetDescription(), 100, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Gulerod.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Peberfrugt.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Citron.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Kyllingbryst.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Karry.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Tabasco.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 1, QuantityType.dl),
            }
                });

                // Kyllingelår med rødder, lakrids og linser
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kyllingelår med rødder, lakrids og linser",
                    Type = MealType.Dinner,
                    Ratio = 1.0,
                    Persons = 1,
                    Page = 162,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Kyllingelår.GetDescription(), 3, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Lakridspulver.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.GrønneLinser.GetDescription(), 1, QuantityType.dl),
                addFoodToRecipe(IngredientHelper.Honning.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Sennep.GetDescription(), 1, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Lime.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Timian.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Persillerod.GetDescription(), 1, QuantityType.tsk),
            }
                });

                // Kylling med aubergine, tomat og kanel
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kylling med aubergine, tomat og kanel",
                    Type = MealType.Dinner,
                    Ratio = 14.0,
                    Persons = 4,
                    Page = 164,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.HelKylling.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Kanel.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Nelliker.GetDescription(), 3, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Aubergine.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Tomat.GetDescription(), 2, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Persillerod.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 1, QuantityType.dl),
                addFoodToRecipe(IngredientHelper.Olivenolie.GetDescription(), 0, QuantityType.Ingen),
            }
                });

                // Kyllingefilet med pærer, druer og ris
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kyllingefilet med pærer, druer og ris",
                    Type = MealType.Dinner,
                    Ratio = 1.1,
                    Persons = 1,
                    Page = 166,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Pære.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Honning.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Pecorinoost.GetDescription(), 30, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.BruneRis.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Druer.GetDescription(), 10, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Mynte.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Mandler.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Kyllingbryst.GetDescription(), 1, QuantityType.stk),
            }
                });

                // Kylling med gulerødder
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kylling med gulerødder",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 168,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Kyllingelår.GetDescription(), 2, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Æblemost.GetDescription(), 1, QuantityType.dl),
                addFoodToRecipe(IngredientHelper.Laurbærblade.GetDescription(), 3, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Gulerod.GetDescription(), 2, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Hvidkål.GetDescription(), 80, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Dild.GetDescription(), 0, QuantityType.Ingen),
            }
                });

                // Laks med avokado, ærter og sesam
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Laks med avokado, ærter og sesam",
                    Type = MealType.Dinner,
                    Ratio = 1.1,
                    Persons = 1,
                    Page = 170,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Laksefilet.GetDescription(), 150, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Spidskommen.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Avokado.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Citron.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.FrosneÆrter.GetDescription(), 0.75, QuantityType.dl),
                addFoodToRecipe(IngredientHelper.Fennikel.GetDescription(), 0.25, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 2, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Sesamfrø.GetDescription(), 1, QuantityType.spsk),
            }
                });

                // Laksefrikadeller med kikærter og kål
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Laksefrikadeller med kikærter og kål",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 172,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Laksefilet.GetDescription(), 120, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Lime.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Ingefær.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Chili.GetDescription(), 0.5, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Kikærter.GetDescription(), 0.5, QuantityType.dåse),
                addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Olivenolie.GetDescription(), 0, QuantityType.Ingen),
                addFoodToRecipe(IngredientHelper.Hvidkål.GetDescription(), 120, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Lime.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 1, QuantityType.dl),
                addFoodToRecipe(IngredientHelper.Spidskommen.GetDescription(), 1, QuantityType.tsk),
            }
                });

                // Råsyltet laks med ingefær og lime
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Råsyltet laks med ingefær og lime",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 174,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Laksefilet.GetDescription(), 120, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Ingefær.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Lime.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Rugbrød.GetDescription(), 1, QuantityType.skive),
                addFoodToRecipe(IngredientHelper.Radicchio.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Dild.GetDescription(), 0, QuantityType.Ingen),
            }
                });

                // Æggepandekage med makrel, tomater og rugbrød
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Æggepandekage med makrel, tomater og rugbrød",
                    Type = MealType.Dinner,
                    Ratio = 1.3,
                    Persons = 1,
                    Page = 176,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 2, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Tomat.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Gulerod.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Makrel.GetDescription(), 1, QuantityType.dåse),
                addFoodToRecipe(IngredientHelper.Rugbrød.GetDescription(), 1, QuantityType.skive),
                addFoodToRecipe(IngredientHelper.Persille.GetDescription(), 0, QuantityType.Ingen),
            }
                });

                // Tun i wasabi med kål, mandler og agurker
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Tun i wasabi med kål, mandler og agurker",
                    Type = MealType.Dinner,
                    Ratio = 1.8,
                    Persons = 1,
                    Page = 178,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Agurk.GetDescription(), 10, QuantityType.skive),
                addFoodToRecipe(IngredientHelper.Wasabi.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Sojasovs.GetDescription(), 2, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Spidskål.GetDescription(), 80, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Citron.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Tun.GetDescription(), 1, QuantityType.dåse),
                addFoodToRecipe(IngredientHelper.Mandler.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 2, QuantityType.spsk),
            }
                });

                // Torskerogn med surt, æg og salat
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Torskerogn med surt, æg og salat",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 180,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Rugbrød.GetDescription(), 1, QuantityType.skive),
                addFoodToRecipe(IngredientHelper.Sennep.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Torskerogn.GetDescription(), 0.5, QuantityType.dåse),
                addFoodToRecipe(IngredientHelper.Drueagurker.GetDescription(), 4, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.SyltedeAsier.GetDescription(), 2, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Persillerod.GetDescription(), 1, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Mandler.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Honning.GetDescription(), 1, QuantityType.tsk),
                addFoodToRecipe(IngredientHelper.Citron.GetDescription(), 0.5, QuantityType.stk),
            }
                });

                // Rejer med chili, grapefrugt og kål
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Rejer med chili, grapefrugt og kål",
                    Type = MealType.Dinner,
                    Ratio = 1.4,
                    Persons = 1,
                    Page = 182,
                    Ingredients = new ObservableCollection<Ingredient>()
            {
                addFoodToRecipe(IngredientHelper.Rødkål.GetDescription(), 70, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Chili.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Rejer.GetDescription(), 100, QuantityType.gram),
                addFoodToRecipe(IngredientHelper.Grapefrugt.GetDescription(), 0.5, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Rødløg.GetDescription(), 2, QuantityType.stk),
                addFoodToRecipe(IngredientHelper.Sojasovs.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Fishsauce.GetDescription(), 1, QuantityType.spsk),
                addFoodToRecipe(IngredientHelper.Mandler.GetDescription(), 1, QuantityType.spsk),
            }
                });

                // Torsk med sennepsrødder
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Torsk med sennepsrødder",
                    Type = MealType.Dinner,
                    Ratio = 1.3,
                    Persons = 1,
                    Page = 184,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.Torsk.GetDescription(), 120, QuantityType.gram),
                    addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Chiafrø.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Citron.GetDescription(), 0.5, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Gulerod.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Persillerod.GetDescription(), 0.5, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Knoldselleri.GetDescription(), 50, QuantityType.gram),
                    addFoodToRecipe(IngredientHelper.Jordskok.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Hasselnødder.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Vindruekerneolie.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Vineddike.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Sennep.GetDescription(), 1, QuantityType.tsk),
                }
                });

                // Laks med urter, syrlige agurker og æg 
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Laks med urter, syrlige agurker og æg",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 186,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.Laksefilet.GetDescription(), 120, QuantityType.gram),
                    addFoodToRecipe(IngredientHelper.Purløg.GetDescription(), 0, QuantityType.Ingen),
                    addFoodToRecipe(IngredientHelper.Dild.GetDescription(), 0, QuantityType.Ingen),
                    addFoodToRecipe(IngredientHelper.Basilikum.GetDescription(), 0, QuantityType.Ingen),
                    addFoodToRecipe(IngredientHelper.Persille.GetDescription(), 0, QuantityType.Ingen),
                    addFoodToRecipe(IngredientHelper.Æbleeddike.GetDescription(), 1, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Agurk.GetDescription(), 0.25, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Rugkerner.GetDescription(), 50, QuantityType.gram),
                    addFoodToRecipe(IngredientHelper.Æg.GetDescription(), 1, QuantityType.stk),
                }
                });

                // Kødsovs med paste
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kødsovs med paste",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 2,
                    Page = 188,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.HakketOksekød.GetDescription(), 250, QuantityType.gram),
                    addFoodToRecipe(IngredientHelper.Rødløg.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Hvidløg.GetDescription(), 4, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Gulerod.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.FlåedeTomater.GetDescription(), 1, QuantityType.dåse),
                    addFoodToRecipe(IngredientHelper.GrønneLinser.GetDescription(), 1, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Olivenolie.GetDescription(), 0, QuantityType.Ingen),
                    addFoodToRecipe(IngredientHelper.Citron.GetDescription(), 0.5, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.GrovPasta.GetDescription(), 80, QuantityType.gram),
                    addFoodToRecipe(IngredientHelper.Parmesanost.GetDescription(), 2, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Knoldselleri.GetDescription(), 100, QuantityType.gram),
                }
                });

                // Chili con carne med skyr, æbler og sennep
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Chili con carne med skyr, æbler og sennep",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 2,
                    Page = 190,
                    Ingredients = new ObservableCollection<Ingredient>()
                {
                    addFoodToRecipe(IngredientHelper.HakketOksekød.GetDescription(), 250, QuantityType.gram),
                    addFoodToRecipe(IngredientHelper.Rødløg.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Hvidløg.GetDescription(), 2, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Gulerod.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Chili.GetDescription(), 1, QuantityType.spsk),
                    addFoodToRecipe(IngredientHelper.Bønner.GetDescription(), 1, QuantityType.dåse),
                    addFoodToRecipe(IngredientHelper.Øl.GetDescription(), 0.5, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Chokolade.GetDescription(), 20, QuantityType.gram),
                    addFoodToRecipe(IngredientHelper.Rødkål.GetDescription(), 200, QuantityType.gram),
                    addFoodToRecipe(IngredientHelper.Æble.GetDescription(), 1, QuantityType.stk),
                    addFoodToRecipe(IngredientHelper.Skyr.GetDescription(), 1, QuantityType.dl),
                    addFoodToRecipe(IngredientHelper.Sennep.GetDescription(), 1, QuantityType.spsk),
                }
                });

                // Sprød torsk, råt grønt og sellericreme
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Sprød torsk, råt grønt og sellericreme",
                    Type = MealType.Dinner,
                    Ratio = 0.7,
                    Persons = 1,
                    Page = 192,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Selleri.GetDescription(),
                        Quantity = 0.25,
                        DefaultQuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Torsk.GetDescription(),
                        Quantity = 120,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 50,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Persillerod.GetDescription(),
                        Quantity = 50,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rødbeder.GetDescription(),
                        Quantity = 50,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        DefaultQuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.stk
                    },
                }
                });

                // Grønt og rejer i rispapir
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Grønt og rejer i rispapir",
                    Type = MealType.Dinner,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 194,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Rejer.GetDescription(),
                        Quantity = 100,
                        DefaultQuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Forårsløg.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Peberfrugt.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Basilikum.GetDescription(),
                        Quantity = 0,
                        DefaultQuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Fennikel.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Sesamfrø.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rispapir.GetDescription(),
                        Quantity = 2,
                        DefaultQuantityType = QuantityType.plade
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Fishsauce.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Lime.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Chili.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.SaltedePeanuts.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Jordnøddeolie.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.spsk
                    },
                }
                });

                // Frikadeller med rug, ramsløg og salat
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Frikadeller med rug, ramsløg og salat",
                    Type = MealType.Dinner,
                    Ratio = 1.3,
                    Persons = 4,
                    Page = 196,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.HakketOksekød.GetDescription(),
                        Quantity = 500,
                        DefaultQuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 3,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mælk.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.dl,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rugflager.GetDescription(),
                        Quantity = 100,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æblemost.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.dl,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hvidløg.GetDescription(),
                        Quantity = 4,
                        DefaultQuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rapsolie.GetDescription(),
                        Quantity = 2,
                        DefaultQuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Edamamebønner.GetDescription(),
                        Quantity = 100,
                        DefaultQuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        DefaultQuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Spidskål.GetDescription(),
                        Quantity = 80,
                        DefaultQuantityType = QuantityType.gram
                    },
                }
                });

                // Torsk og tomatsalat
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Torsk og tomatsalat",
                    Type = MealType.Dinner,
                    Ratio = 1.02,
                    Persons = 1,
                    Page = 198,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Torsk.GetDescription(),
                        Quantity = 150,
                        DefaultQuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Tomat.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rødløg.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Persille.GetDescription(),
                        Quantity = 0,
                        DefaultQuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rugkerner.GetDescription(),
                        Quantity = 50,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Oliven.GetDescription(),
                        Quantity = 7,
                        DefaultQuantityType = QuantityType.stk
                    },
                }
                });

                // Pizza med frisk grønt og kylligefilet
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Pizza med frisk grønt og kylligefilet",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 200,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Pizza.GetDescription(),
                        Quantity = 0.25,
                        DefaultQuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Kyllingbryst.GetDescription(),
                        Quantity = 120,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 150,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        DefaultQuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Basilikum.GetDescription(),
                        Quantity = 0,
                        DefaultQuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Forårsruller med kål og kød
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Forårsruller med kål og kød",
                    Type = MealType.Dinner,
                    Ratio = 1.3,
                    Persons = 2,
                    Page = 202,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Kyllingbryst.GetDescription(),
                        Quantity = 200,
                        DefaultQuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rødkål.GetDescription(),
                        Quantity = 100,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Ingegær.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.tsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 2,
                        DefaultQuantityType = QuantityType.spsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Sojasovs.GetDescription(),
                        Quantity = 2,
                        DefaultQuantityType = QuantityType.spsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Forårsrulledej.GetDescription(),
                        Quantity = 4,
                        DefaultQuantityType = QuantityType.plade,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Vindruekerneolie.GetDescription(),
                        Quantity = 0,
                        DefaultQuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Rodfrugter på panden med chorizopølser
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Rodfrugter på panden med chorizopølser",
                    Type = MealType.Dinner,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 204,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Chorizopølser.GetDescription(),
                        Quantity = 4,
                        DefaultQuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Persillerod.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rødløg.GetDescription(),
                        Quantity = 0.25,
                        DefaultQuantityType = QuantityType.stk,
                    },
                }
                });

                // Dumblings med fisk og grønt, hertil råkost
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Dumblings med fisk og grønt, hertil råkost",
                    Type = MealType.Dinner,
                    Ratio = 0.7,
                    Persons = 1,
                    Page = 206,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Blomkålsbuketter.GetDescription(),
                        Quantity = 50,
                        DefaultQuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Broccoli.GetDescription(),
                        Quantity = 50,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Wontondej.GetDescription(),
                        Quantity = 5,
                        DefaultQuantityType = QuantityType.plade,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Torsk.GetDescription(),
                        Quantity = 100,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Sojasovs.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.tsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.tsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Spidskål.GetDescription(),
                        Quantity = 50,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.stk,
                    },
                }
                });

                // Kalv i øl og timian
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kalv i øl og timian",
                    Type = MealType.Dinner,
                    Ratio = 1.1,
                    Persons = 1,
                    Page = 208,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Kalvekotelet.GetDescription(),
                        Quantity = 300,
                        DefaultQuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Broccoli.GetDescription(),
                        Quantity = 50,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Spidskål.GetDescription(),
                        Quantity = 50,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 50,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Timian.GetDescription(),
                        Quantity = 2,
                        DefaultQuantityType = QuantityType.spsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Sennep.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.tsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Radicchio.GetDescription(),
                        Quantity = 0.25,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Øl.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Fuldkornsbrød.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.skive,
                    },
                }
                });

                // Kartofler med æg og salat
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kartofler med æg og salat",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 210,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Hjertesalat.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Kartofler.GetDescription(),
                        Quantity = 80,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Forårsløg.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        DefaultQuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Vineddike.GetDescription(),
                        Quantity = 0,
                        DefaultQuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 2,
                        DefaultQuantityType = QuantityType.stk,
                    },
                }
                });

                // Edamamebønner med spidskål og dild
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Edamamebønner med spidskål og dild",
                    Type = MealType.Dinner,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 212,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Edamamebønner.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.pose
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.dl,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.spsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        DefaultQuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Spidskål.GetDescription(),
                        Quantity = 100,
                        DefaultQuantityType = QuantityType.gram,
                    },
                }
                });

                // Kotelet i fad med mynte, kartofler og appelsin
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kotelet i fad med mynte, kartofler og appelsin",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 214,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.RødAppelsin.GetDescription(),
                        Quantity = 0.0,
                        DefaultQuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mynte.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Kartofler.GetDescription(),
                        Quantity = 75,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Svinekotelet.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.spsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Sojasovs.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.spsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.spsk,
                    },
                }
                });

                // Kød med syrlige kartofler og parmesan
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Kød med syrlige kartofler og parmesan",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 216,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Oksebøf.GetDescription(),
                        Quantity = 150,
                        DefaultQuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Kartofler.GetDescription(),
                        Quantity = 6,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Eddike.GetDescription(),
                        Quantity = 0.5,
                        DefaultQuantityType = QuantityType.dl,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rosmarin.GetDescription(),
                        Quantity = 2,
                        DefaultQuantityType = QuantityType.spsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Parmesanost.GetDescription(),
                        Quantity = 20,
                        DefaultQuantityType = QuantityType.gram,
                    },
                }
                });

                // Fiskefilet med salat
                dbContext.Recipes.InsertOne(new Recipe()
                {
                    Name = "Fiskefilet med salat",
                    Type = MealType.Dinner,
                    Ratio = 1.7,
                    Persons = 1,
                    Page = 218,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Fiskefilet.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mysli.GetDescription(),
                        Quantity = 25,
                        DefaultQuantityType = QuantityType.gram,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Vindruekerneolie.GetDescription(),
                        Quantity = 0,
                        DefaultQuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Radicchio.GetDescription(),
                        Quantity = 0.25,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Drueagurker.GetDescription(),
                        Quantity = 4,
                        DefaultQuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        DefaultQuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                #endregion
            }





            //#region Desserter

            //// Honningbruschetta

            //// Koldskål

            //// Æggesnaps med tørrede bær

            //// Trifli med mango, makroner og skyr

            //// Marengs med chokolade og frugtskyr

            //#endregion

            //#region Grundopskrifter

            //#endregion

            var list = dbContext.Recipes.Find(a => true).ToList();

            return list;
        }

        private Ingredient addFoodToRecipe(string Id, double quantity, string quantityType, bool basicRecipe = false, string defaultQuantityType = QuantityType.gram)
        {
            if (int.TryParse(Id, out int result))
            {
                if (dbContext.Foods.Find(a => a.FoodId == result).Count() == 0)
                    throw new IndexOutOfRangeException("addFoodToRecipe, Id: " + Id.ToString() + " indgår ikke i DbContext.Foods");

                if (!QuantityType.Current.CompleteListOfQuantityTypes.Any(a => a == quantityType))
                    throw new Exception("addFoodToRecipe, quantityType: " + quantityType + " indgår ikke i QuantityType.Current.CompleteListOfQuantityTypes");

                var food = dbContext.Foods.Find(a => a.FoodId == result).First();

                Ingredient newIngredient = new Ingredient()
                {
                    Food = food,
                    Quantity = quantity,
                    QuantityType = quantityType,
                    DefaultQuantityType = defaultQuantityType,
                    BasicRecipe = basicRecipe
                };

                if (quantityType == QuantityType.Ingen)
                    newIngredient.QuantityVisible = false;

                return newIngredient;
            }
            else
            {
                throw new Exception("addFoodToRecipe, Id: " + Id + " er ikke en int");
            }
        }

    }
}