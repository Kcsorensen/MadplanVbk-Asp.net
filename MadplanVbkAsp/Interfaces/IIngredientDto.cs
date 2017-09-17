namespace MadplanVbkAsp.Interfaces
{
    public interface IIngredientDto
    {
        string Name { get; set; }
        double Quantity { get; set; }
        string QuantityType { get; set; }
    }
}
