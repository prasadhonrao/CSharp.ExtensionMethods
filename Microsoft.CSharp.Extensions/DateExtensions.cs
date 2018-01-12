using System;

namespace Microsoft.CSharp.Extensions
{
    public static class DateExtensions
    {
        #region GetOrdinalSuffix

        /// <summary>
        /// Get the ordinal suffix for a given date
        /// </summary>
        /// <param name="datetime">Input date</param>
        /// <returns>Ordinal suffix of a given input date</returns>
        public static string GetOrdinalSuffix(this DateTime datetime)
        {
            int day = datetime.Day;

            if (day % 100 >= 11 && day % 100 <= 13)
                return String.Concat(day, "th");

            switch (day % 10)
            {
                case 1:
                    return String.Concat(day, "st");
                case 2:
                    return String.Concat(day, "nd");
                case 3:
                    return String.Concat(day, "rd");
                default:
                    return String.Concat(day, "th");
            }
        }

        #endregion

        #region Tomorrow

        public static DateTime Tomorrow(this DateTime datetime)
        {
            return datetime.AddDays(1);
        }

        #endregion

        #region Yesterday

        public static DateTime Yesterday(this DateTime datetime)
        {
            return datetime.AddDays(-1);
        }

        #endregion
    }
}
