using SharedLib.Models;
using System;
using System.Collections.ObjectModel;

namespace MadplanVbkAsp.Interfaces
{
    public interface IRecipeDto
    {
        Recipe Recipe { get; set; }

        void Clear();
    }
}
