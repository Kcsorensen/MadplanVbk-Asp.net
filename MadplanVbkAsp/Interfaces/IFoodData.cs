using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadplanVbkAsp.Interfaces
{
    public interface IFoodData
    {
        List<Food> GetAll();
        Food Get(int id);
        void Add(Food newFood);
        void Remove(Guid id);
    }
}
