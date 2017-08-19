using MadplanVbkAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadplanVbkAsp.Interface
{
    public interface IFoodData
    {
        IEnumerable<Food> GetAll();
        Food Get(int id);
        void Add(Food newFood);
    }
}
