using System;

namespace Microsoft.CSharp.Extensions
{
    public static class IntExtensions
    {
        #region Factorial

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

        #region ReverseDigits

        public static int ReverseDigits(this int input)
        {
            char[] digits = input.ToString().ToCharArray();
            Array.Reverse(digits);
            string newDigits = new string(digits);
            return int.Parse(newDigits);
        } 

        #endregion
    }
}
