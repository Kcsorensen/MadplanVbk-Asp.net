using SharedLib.Models;
using System.Collections.Generic;

namespace MadplanVbkAsp.Interface
{
    public interface IFoodData
    {
        List<Food> GetAll();
        Food Get(int id);
        void Add(Food newFood);
    }
}
