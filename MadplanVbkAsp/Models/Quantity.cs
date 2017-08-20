using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MadplanVbkAsp.Models
{
    public class Quantity
    {
        public int QuantityId { get; set; }

        [MaxLength(255)]
        [Required]
        public string Name { get; set; }

        public double Value { get; set; }
    }
}
