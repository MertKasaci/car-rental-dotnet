using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Enums.Helpers
{
    public static class EnumExtensions
    {
        public static IDictionary<string, T> GetEnumValues<T>(this T enumType) where T : Enum
        {
            return Enum.GetValues(typeof(T))
                       .Cast<T>()
                       .ToDictionary(t => t.ToString(), t => t);
        }
    }
}
