using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Microsoft.CSharp.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Convert an input string to integer
        /// Usage: var count = strCount.ToInt();
        /// </summary>
        /// <param name="input">input string parameter which needs to be converted to integer</param>
        /// <returns>integer value of input string. Zero if input string cannot be converted to an integer</returns>
        public static int ToInt(this String input)
        {
            int result;
            if (!int.TryParse(input, out result))
            {
                result = 0;
            }
            return result;
        }

        /// <summary>
        /// Get the word count from an input string
        /// </summary>
        /// <param name="input">input string parameter from which words needs to be counted</param>
        /// <returns>integer value indicating number of words</returns>
        public static int GetWordCount(this string input)
        {
            if (input.Trim().Length == 0)
                return 0;

            return Regex.Split(input, @"\W+").Length;
        }

        /// <summary>
        /// Find if all the characters from given input string are in upper case or not
        /// </summary>
        /// <param name="input">input string whose individual characters needs to be checked</param>
        /// <returns>Boolen result (true / false) indicating whether all the characters are in upper case or not</returns>
        public static bool IsAllUpper(this string input)
        {
            char[] chars = input.ToCharArray();
            return chars.All(c => (char.IsUpper(c) || char.IsWhiteSpace(c)));
        }

        /// <summary>
        /// Find if all the characters from given input string are in lower case or not
        /// </summary>
        /// <param name="input">input string whose individual characters needs to be checked</param>
        /// <returns>Boolen result (true / false) indicating whether all the characters are in lower case or not</returns>
        public static bool IsAllLower(this string input)
        {
            char[] chars = input.ToCharArray();
            return chars.All(c => (char.IsLower(c) || char.IsWhiteSpace(c)));
        }
    }
}
