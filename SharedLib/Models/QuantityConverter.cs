using System.Collections.Generic;

namespace SharedLib.Models
{
    public class QuantityConverter
    {
        public List<Quantity> Quantities { get; set; }

        public QuantityConverter()
        {
            Quantities = new List<Quantity>();

            foreach (var quantityType in QuantityType.Current.ListForQuantityConverter)
            {
                Quantities.Add(new Quantity() { Name = quantityType, Value = 0.0 });
            }
        }
    }
}
