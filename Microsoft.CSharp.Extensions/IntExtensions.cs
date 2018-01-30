using System;

namespace Microsoft.CSharp.Extensions
{
    /// <summary>
    /// Int Extension Type
    /// </summary>
    public static class IntExtensions
    {
        #region Factorial

        /// <summary>
        /// Function to find a factorial of a given number
        /// </summary>
        /// <param name="input">Integer input value</param>
        /// <returns>Factorial of a given integer input</returns>
        public static long Factorial(this int input)
        {
            long factorial = 1;
            while (input > 0)
            {
                factorial = factorial * input;
                input = input - 1;
            }
            return factorial;
        }

        #endregion

        #region Reverse

        public static int Reverse(this int input)
        {
            char[] digits = input.ToString().ToCharArray();
            Array.Reverse(digits);
            string newDigits = new string(digits);
            return int.Parse(newDigits);
        } 

        #endregion
    }
}
