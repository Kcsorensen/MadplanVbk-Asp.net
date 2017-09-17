using MadplanVbkAsp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedLib.Models;

namespace MadplanVbkAsp.Dtos
{
    public class IngredientDto : IIngredientDto
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string QuantityType { get; set; }

    }
}
