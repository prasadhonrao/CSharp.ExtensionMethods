using Newtonsoft.Json;
using System.Diagnostics;

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
            var serializerSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ObjectCreationHandling = ObjectCreationHandling.Auto,
                Formatting = Formatting.Indented
            };

            var serializedStr = JsonConvert.SerializeObject(string.Empty, Formatting.Indented, serializerSettings);
            Debug.WriteLine("*************** Serialized JSON ***************************");
            Debug.WriteLine(serializedStr);

            return input != null ? JsonConvert.SerializeObject(input, Formatting.Indented, serializerSettings) : null;
        }
    }
}
