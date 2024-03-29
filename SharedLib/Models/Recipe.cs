﻿using System;
using System.Collections.ObjectModel;

namespace SharedLib.Models
{
    public class Recipe
    {
        public const string Default = "Vælg måltid";

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string DefaultQuantityType { get; set; }
        public bool IsProtected { get; set; }
        public double Ratio { get; set; }
        public double Persons { get; set; }
        public int Page { get; set; }

        public ObservableCollection<Ingredient> Ingredients { get; set; }

        public Recipe()
        {
            Id = Guid.NewGuid();
            Type = "Vælg";
            DefaultQuantityType = QuantityType.gram;
            Ingredients = new ObservableCollection<Ingredient>();
            IsProtected = false;
        }

        public Recipe(bool isProtected)
        {
            Id = Guid.NewGuid();
            Type = "Vælg";
            DefaultQuantityType = QuantityType.gram;
            Ingredients = new ObservableCollection<Ingredient>();
            IsProtected = true;
        }
    }
}
