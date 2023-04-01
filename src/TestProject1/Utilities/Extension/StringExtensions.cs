using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Utilities.Extension
{
    public static class StringExtensions
    {
        public static bool AsBoolean(this string value)
        {
            return Convert.ToBoolean(value);
        }

        public static int AsInt(this string value)
        {
            return Convert.ToInt32(Convert.ToDecimal(value));
        }
    }
}
