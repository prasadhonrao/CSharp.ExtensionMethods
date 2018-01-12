using System;
using System.ComponentModel;
using System.Reflection;

namespace Microsoft.CSharp.Extensions
{
    /// <summary>
    /// Enum Extension Class
    /// </summary>
    public static class EnumExtensions
    {
        #region GetDescription
        
        /// <summary>
        /// Get description value of an Enum value
        /// </summary>
        /// <param name="value">Enum value of which description needs to be returned</param>
        /// <returns>Description of a given enum value</returns>
        public static string GetDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null) return null;
            var attribute = (DescriptionAttribute)fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute));
            return attribute == null ? string.Empty : attribute.Description;
        }

        #endregion
    }

    /// <summary>
    /// Generic Enum Class (.NET Framework doesnot support Generic Enum Type so far, however revisit this code once its part of.NET Framework)
    /// </summary>
    /// <typeparam name="T">Generic Type Parameter</typeparam>
    public class Enum<T> where T : struct, IConvertible
    {
        public static int Count
        {
            get
            {
                if (!typeof(T).IsEnum)
                    throw new ArgumentException("T must be an enumerated type");

                return Enum.GetNames(typeof(T)).Length;
            }
        }
    }
}
