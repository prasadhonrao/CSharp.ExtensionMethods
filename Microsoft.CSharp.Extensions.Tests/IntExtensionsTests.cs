using NUnit.Framework;

namespace Microsoft.CSharp.Extensions.Tests
{
    [TestFixture]
    public class IntExtensionsTests
    {
        #region Factorial

        [Test]
        public void Factorial_Valid_Int_Test()
        {
            var result = 5.Factorial();
            Assert.AreEqual(120, result);
        }

        [Test]
        public void Factorial_Zero_Test()
        {
            var result = 0.Factorial();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Factorial_One_Test()
        {
            var result = 1.Factorial();
            Assert.AreEqual(1, result);
        }


        [Test]
        public void Factorial_Long_Number_Test()
        {
            var result = 10.Factorial();
            Assert.AreEqual(3628800, result);
        }

        #endregion

        #region Reverse

        [Test]
        public void ReverseDigits_Valid_Int_Test()
        {
            var result = 12345.Reverse();
            Assert.AreEqual(54321, result);
        }

        [Test]
        public void ReverseDigits_Zero_Test()
        {
            var result = 0.Reverse();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ReverseDigits_SameNumber_Test()
        {
            var result =  111.Reverse();
            Assert.AreEqual(111, result);
        }

        #endregion
    }
}
