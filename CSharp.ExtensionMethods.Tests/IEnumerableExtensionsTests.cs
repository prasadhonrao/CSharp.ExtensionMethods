using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CSharp.ExtensionMethods.Tests
{
    [TestFixture]
    public class IEnumerableExtensionsTests
    {
        #region Shuffle

        [Test]
        public void Shuffle_Integer_Collection_Test()
        {
            var result = new List<int>() { 1, 2, 3, 4, 5 }.Shuffle();
            Assert.IsTrue(result.ToList().Count > 0);
        }

        [Test]
        public void Shuffle_String_Collection_Test()
        {
            var result = new List<string>() { "a", "b", "c", "d", "e" }.Shuffle();
            Assert.IsTrue(result.ToList().Count > 0);
        }

        [Test]
        public void Shuffle_Mixed_Collection_Test()
        {
            var result = new List<object>() { "a", 1, new List(), DateTime.Now, null }.Shuffle();
            Assert.IsTrue(result.ToList().Count > 0);
        }

        [Test]
        public void Shuffle_Null_Collection_Test()
        {
            var nullList = new List<int>();
            nullList = null;
            Assert.That(() => nullList.Shuffle(), Throws.TypeOf<ArgumentNullException>());
        }

        #endregion
    }
}
