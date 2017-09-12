using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Extensions
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class MyDescriptionAttribute : Attribute
    {
        public virtual string Text { get; set; }
    }
}
