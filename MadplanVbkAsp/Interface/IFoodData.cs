using SharedLib.Models;
using System.Collections.Generic;

namespace MadplanVbkAsp.Interface
{
    public interface IFoodData
    {
        IEnumerable<Food> GetAll();
        Food Get(int id);
        void Add(Food newFood);
    }
}
