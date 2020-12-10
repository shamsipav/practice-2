using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Новая_папка
{
    public class Functions
    {
        public static string ZeroDigitToEmpty(int number)
        {
            if (number == 0)
            {
                return "";
            }

            return number.ToString();
        }
    }
}
