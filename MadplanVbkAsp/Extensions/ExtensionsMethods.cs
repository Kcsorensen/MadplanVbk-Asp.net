using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace MadplanVbkAsp.Extensions
{
    public static class ExtensionsMethods
    {
        #region EnumHelper

        public static string Description(this Enum value)
        {
            // get attributes  
            var field = value.GetType().GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            // return description
            return attributes.Any() ? ((DescriptionAttribute)attributes.ElementAt(0)).Description : "Description Not Found";
        }

        #endregion

        #region String to Double Converter

        public static string ConvertToDouble(this string stringVal)
        {
            var doubleVal = double.NaN;

            if (!string.IsNullOrWhiteSpace(stringVal))
            {
                doubleVal = Convert.ToDouble(stringVal, new CultureInfo("da-DK"));
            }

            return doubleVal.ToString();
        }

        #endregion

    }
}
