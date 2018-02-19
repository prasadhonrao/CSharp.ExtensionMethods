using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ExtensionMethods
{
    public static class IEnumerableExtensions
    {
        #region Shuffle

        static public IEnumerable<T> Shuffle<T>(this IEnumerable<T> collection)
        {
            if (collection == null) throw new ArgumentNullException("Input collection cannot be null");

            return ShuffleIterator(collection);
        }

        static private IEnumerable<T> ShuffleIterator<T>(this IEnumerable<T> source)
        {
            T[] array = source.ToArray();
            Random rnd = new Random();
            for (int n = array.Length; n > 1;)
            {
                int k = rnd.Next(n--); // 0 <= k < n

                //Swap items
                if (n != k)
                {
                    T tmp = array[k];
                    array[k] = array[n];
                    array[n] = tmp;
                }
            }

            foreach (var item in array) yield return item;
        } 

        #endregion
    }
}
