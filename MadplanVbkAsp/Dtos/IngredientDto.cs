using MadplanVbkAsp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedLib.Models;
using System.ComponentModel.DataAnnotations;

namespace MadplanVbkAsp.Dtos
{
    public class IngredientDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Værdien i feltet skal være et tal")]
        public double Quantity { get; set; }
        public string QuantityType { get; set; }

    }
}
