using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS_SimpleClass.AppClasses
{
    internal class SimpleOperations
    {
        public double Popwer(double x, double y)
        {
            // if(y <= 0) return 1;
            if (!CheckDenominator(y)) return 1;
            return Math.Pow(x, y);
        }

        public int Division(int x, int y)
        {
            // if(y == 0) return 0;
            if (!CheckDenominator(y)) return 0;
            return x / y;
        }

        public string Reverse(string str)
        {
            string result = string.Empty;

            if (String.IsNullOrEmpty(str)) return "The input string is not valid";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
        /// <summary>
        /// Use object as data type for input parameter so that we can use it for
        /// validating any input parameter
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool CheckDenominator(object y)
        {
            // 1. Chekc for double type
            if (y.GetType() == typeof(double))
            {
                if(Convert.ToDouble(y) <= 0) return false;
            }

            if (y.GetType() == typeof(int))
            {
                if (Convert.ToInt32(y) <= 0) return false;
            }
            return true;
        }
    }
}
