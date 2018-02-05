using Newtonsoft.Json;

namespace Microsoft.CSharp.Extensions
{
    /// <summary>
    /// Generic Extension Type
    /// </summary>
    public static class GenericExtensions
    {
        /// <summary>
        /// ToJson converts a given object representation to JSON format
        /// </summary>
        /// <typeparam name="T">Generic input parameter</typeparam>
        /// <param name="input">JSON representation of input value</param>
        /// <returns></returns>
        public static string ToJson<T>(this T input)
        {
            return input != null ? JsonConvert.SerializeObject(input) : null;
        }
    }
}
