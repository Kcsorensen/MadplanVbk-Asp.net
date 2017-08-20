using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MadplanVbkAsp.Models
{
    public class QuantityConverter
    {
        public int QuantityConverterId { get; set; }

        public ICollection<Quantity> Quantities { get; set; }

        public QuantityConverter()
        {
            Quantities = new HashSet<Quantity>();

            //Conversions = GetNewListOfQuantityValues();

            //Conversions = new List<Quantity>();

            //foreach (var quantityType in QuantityType.Current.CompleteListOfQuantityTypes)
            //{
            //    Conversions.Add(new Quantity() { Name = quantityType, Value = 0.0 });
            //}
        }

        //public static List<Quantity> GetNewListOfQuantityValues()
        //{
        //    var list = new List<Quantity>();

        //    foreach (var quantityType in QuantityType.Current.CompleteListOfQuantityTypes)
        //    {
        //        list.Add(new Quantity() { Name = quantityType, Value = 0.0 });
        //    }

        //    return list;
        //}
    }
}
