using System.Globalization;

namespace CSharp.ExtensionMethods
{
    /// <summary>
    /// Double Extension Type
    /// </summary>
    public static class DoubleExtensions
    {
        #region ToCurrency

        /// <summary>
        /// Convert a double to string formatted using the specified culture
        /// </summary>
        /// <param name="value">Double value to convert</param>
        /// <param name="cultureName">Culture information</param>
        /// <returns></returns>
        public static string ToCurrency(this double value, string cultureName)
        {
            CultureInfo currentCulture = new CultureInfo(cultureName);
            return (string.Format(currentCulture, "{0:C}", value));
        } 

        #endregion
    }
}
