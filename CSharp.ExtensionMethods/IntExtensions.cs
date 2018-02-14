using System;

namespace CSharp.ExtensionMethods
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

        #region IsArmstrong

        /// <summary>
        /// Function to check whether the entered number is an Armstrong number or not . 
        /// An Armstrong number of three digits is an integer such that the sum of the cubes of its digits is equal to the number itself.
        /// </summary>
        /// <param name="input">Input number</param>
        /// <returns>True if Armstrong, false otherwise</returns>
        public static bool IsArmstrong(this int input)
        {
            if (input <= 0) return false;

            int remainder, sum = 0;
            Console.Write("enter the Number");

            for (int i = input; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;
            }

            if (sum == input)
                return true;
            return false;
        }

        #endregion

        #region IsPerfect

        public static bool IsPerfect(this int input)
        {
            if (input <= 0) return false;

            int sum = 0,
                number = 0;

            number = input;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
                return true;
            return false;
        }


        #endregion

        #region IsPrime

        public static bool IsPrime(this int input)
        {
            if (input <= 0) return false;

            int k = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
                return true;
            return false;
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
