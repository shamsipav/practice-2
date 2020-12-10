using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Extentions
{
    public static class IntExtentions
    {
        public static string ZeroDigitToEmpty(this int number)
        {
            if (number == 0)
            {
                return "";
            }

            return number.ToString();
        }
    }
}
