using System;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Microsoft.CSharp.Extensions
{
    public static class StringExtensions
    {
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

        #region IsAllLower

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

        #endregion

        #region IsAllUpper

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

        #endregion

        #region IsEmail

        public static bool IsEmail(this string email)
        {
            try
            {
                if (String.IsNullOrEmpty(email.Trim()))
                    throw new ArgumentNullException("Email address cannot be null or empty");

                MailAddress address = new MailAddress(email);
                return address != null ? true : false;
            }
            catch (FormatException) // email is not in a recognized format OR email contains non-ASCII characters.
            {
                throw;
            }
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

        #region ToReverseCase

        /// <summary>
        /// Reverse case of all alphabetic character in a given input string
        /// </summary>
        /// <param name="input">input string whose character case needs to be reversed</param>
        /// <returns>string with reverse characters</returns>
        public static string ToReverseCase(this string input)
        {
            return new string(input.Select
                                    (c => char.IsLetter(c) ? (char.IsUpper(c) ?
                                          char.ToLower(c) : char.ToUpper(c)) : c)
                                    .ToArray()
                             );
        }

        #endregion

        #region ToTitleCase

        /// <summary>
        /// Convert the first letter of the input string to Title case / Upper case
        /// </summary>
        /// <param name="input">input string parameter</param>
        /// <returns>String with first letter in title case</returns>
        public static string ToTitleCase(this string input)
        {
            if (input.Length > 0)
            {
                char[] array = input.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return input;
        }

        #endregion
    }
}
