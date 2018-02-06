using System;

namespace CSharp.Extensions.Tests.Helpers
{
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
