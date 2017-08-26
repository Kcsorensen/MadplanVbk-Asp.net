using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Extensions
{
    public static class ExtensionMethods
    {
        #region String to Double Converter

        public static double ConvertToDouble(this string stringVal)
        {
            var doubleVal = double.NaN;

            if (!string.IsNullOrWhiteSpace(stringVal))
            {
                doubleVal = Convert.ToDouble(stringVal, new CultureInfo("da-DK"));
            }

            return doubleVal;
        }

        public static double ToDouble(this string stringVal)
        {
            var doubleVal = double.NaN;

            if (!string.IsNullOrWhiteSpace(stringVal))
            {
                doubleVal = Convert.ToDouble(stringVal);
            }

            return doubleVal;
        }

        #endregion
    }
}
