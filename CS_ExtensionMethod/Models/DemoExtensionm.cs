using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace CS_ExtensionMethod.Models
{
    public sealed class ClsMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }


    public static class MyExtension
    {
        public static int Mult(this ClsMath m, int x,int y)
        {
            return x * y;
        }


        public static int Add(this ClsMath m, int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Extension Method for String
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int GetWordCount(this string str)
        {
            // Split the string into an array of words based on whitespace characters
            string[] words = str.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Return the number of words
            return words.Length;
        }
    }
}
