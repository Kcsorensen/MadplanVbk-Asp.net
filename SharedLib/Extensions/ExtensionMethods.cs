using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Extensions
{
    public static class ExtensionMethods
    {
        #region Description Helper
        public static T GetAttributeOfType<T>(this Enum enumVal) where T : Attribute
        {
            var typeInfo = enumVal.GetType().GetTypeInfo();
            var v = typeInfo.DeclaredMembers.First(x => x.Name == enumVal.ToString());

            return v.GetCustomAttribute<T>();
        }

        public static string GetDescription(this Enum enumVal)
        {
            var attr = GetAttributeOfType<MyDescriptionAttribute>(enumVal);

            return attr != null ? attr.Text : string.Empty;
        }

        #endregion

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

        #region Clone

        public static T Clone<T>(T source)
        {
            var serialized = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(serialized);
        }

        public async static Task<T> CloneAsync<T>(T source)
        {
            return await Task.Run(() =>
            {
                var serialized = JsonConvert.SerializeObject(source);
                return JsonConvert.DeserializeObject<T>(serialized);
            });
        }
        #endregion


    }
}
