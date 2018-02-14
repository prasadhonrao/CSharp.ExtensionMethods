using System;
using System.ComponentModel;
using System.Reflection;

namespace CSharp.ExtensionMethods
{
    /// <summary>
    /// Enum Extension Type
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
            //if (fieldInfo == null) return null;
            var attribute = (DescriptionAttribute)fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute));
            return attribute == null ? string.Empty : attribute.Description;
        }

        #endregion
    }
}
