using System;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Microsoft.CSharp.Extensions
{
    /// <summary>
    /// String Extension Type
    /// </summary>
    public static class StringExtensions
    {
        #region Capitalize

        /// <summary>
        /// Return a capitalized version of given input string i.e. make the first character have upper case and the rest lower case.
        /// </summary>
        /// <param name="input">input string parameter</param>
        /// <returns>String with first letter in upper case</returns>
        public static string Capitalize(this string input)
        {
            if (input.Length > 0)
            {
                char[] array = input.ToLower().ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return input;
        }

        #endregion

        #region GetOccurrenceCount

        // Usage: var count = "supercalifragilisticexpealidocious".GetOccurrenceCount("li"); // returns 3
        /// <summary>
        /// Get the occurence count of a substring in a given input string
        /// </summary>
        /// <param name="input">input string parameter in which a occurence needs to be identified</param>
        /// <param name="searchText">input search text</param>
        /// <returns>integer value returning the number of occurences of a serachText in main input string</returns>
        public static int GetOccurrenceCount(this string input, string searchText)
        {
            if (input.Trim() == string.Empty && searchText.Trim() == string.Empty)
                return 1;
            else if (input.Trim() == string.Empty || searchText.Trim() == string.Empty)
                return 0;
            else
                return Regex.Matches(input, searchText).Count;
        }

        #endregion

        #region GetWordCount

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

        #endregion

        #region IsLower

        /// <summary>
        /// Find if all the characters from given input string are in lower case or not
        /// </summary>
        /// <param name="input">input string whose individual characters needs to be checked</param>
        /// <returns>Boolen result (true / false) indicating whether all the characters are in lower case or not</returns>
        public static bool IsLower(this string input)
        {
            char[] chars = input.ToCharArray();
            return chars.All(c => (char.IsLower(c) || char.IsWhiteSpace(c)));
        }

        #endregion

        #region IsUpper

        /// <summary>
        /// Find if all the characters from given input string are in upper case or not
        /// </summary>
        /// <param name="input">input string whose individual characters needs to be checked</param>
        /// <returns>Boolen result (true / false) indicating whether all the characters are in upper case or not</returns>
        public static bool IsUpper(this string input)
        {
            char[] chars = input.ToCharArray();
            return chars.All(c => (char.IsUpper(c) || char.IsWhiteSpace(c)));
        }

        #endregion

        #region IsEmail
        /// <summary>
        /// Function to identify whether given input string is a valid email address or not
        /// </summary>
        /// <param name="input">String input parameter to check for email validity</param>
        /// <returns>True if given input string is a valid email address, false otherwise</returns>
        public static bool IsEmail(this string input)
        {
            try
            {
                if (String.IsNullOrEmpty(input.Trim()))
                    throw new ArgumentNullException("Email address cannot be null or empty");

                MailAddress address = new MailAddress(input);
                return true;
            }
            catch (FormatException) // email is not in a recognized format OR email contains non-ASCII characters.
            {
                throw;
            }
        }

        #endregion

        #region IsNumeric

        /// <summary>
        /// Function to identify whether given input string can be converted to a valid numeric value or not
        /// </summary>
        /// <param name="input">Input string parameter</param>
        /// <returns>True if given input string is a valid numeric value, false otherwise</returns>
        public static bool IsNumeric(this string input)
        {
            double n;
            var isNumeric = Double.TryParse(input, out n);
            return isNumeric;
        }

        #endregion

        #region IsPalindrome

        /// <summary>
        /// Function to identify whether given input string is palindrome or not
        /// </summary>
        /// <param name="input">String input parameter</param>
        /// <returns>True if given input string is palindrome, false otherwise</returns>
        public static bool IsPalindrome(this string input)
        {
            var reverse = new string(input.ToCharArray().Reverse().ToArray());
            return input.Equals(reverse);
        }

        #endregion

        #region SwapCase

        /// <summary>
        /// Return a copy of given input string with uppercase characters converted to lowercase and vice versa.
        /// </summary>
        /// <param name="input">Input string whose character case needs to be reversed</param>
        /// <returns>String with reverse characters</returns>
        public static string SwapCase(this string input)
        {
            return new string(input.Select
                                    (c => char.IsLetter(c) ? (char.IsUpper(c) ?
                                          char.ToLower(c) : char.ToUpper(c)) : c)
                                    .ToArray()
                             );
        }

        #endregion

        #region TrimAndReduce

        /// <summary>
        /// Extension method to remove all the repeated blank spaces within the String itself, not only at the end or at the start of it
        /// </summary>
        /// <param name="input">string input parameter with extra spaces</param>
        /// <returns>string with repeated blanks spaces removed</returns>
        public static string TrimAndReduce(this string input)
        {
            return Regex.Replace(input, @"\s+", " ").Trim();
        }

        #endregion

        #region ToInt

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

        #endregion

        #region ToTitleCase

        /// <summary>
        /// Converts the specified string to title case (except for words that are entirely in uppercase, which are considered to be acronyms).
        /// </summary>
        /// <param name="input">String input parameter</param>
        /// <returns>String with each word converted to title case</returns>
        public static string ToTitleCase(this string input)
        {
            var strings = input.Split(' ');
            var ret = string.Concat(strings.Select(a => a = a.Capitalize() + " "));
            return ret.Substring(0, ret.Length - 1);
        }

        #endregion

    }
}
