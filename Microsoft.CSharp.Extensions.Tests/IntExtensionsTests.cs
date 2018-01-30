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
        public void Reverse_Valid_Int_Test()
        {
            var result = 12345.Reverse();
            Assert.AreEqual(54321, result);
        }

        [Test]
        public void Reverse_Zero_Test()
        {
            var result = 0.Reverse();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Reverse_SameNumber_Test()
        {
            var result =  111.Reverse();
            Assert.AreEqual(111, result);
        }

        #endregion

        #region IsPrime

        [Test]
        public void IsPrime_Number_0_Test()
        {
            Assert.IsFalse(0.IsPrime());
        }

        [Test]
        public void IsPrime_Number_1_Test()
        {
            Assert.IsFalse(1.IsPrime());
        }

        [Test]
        public void IsPrime_Number_2_Test()
        {
            Assert.IsTrue(2.IsPrime());
        }

        [Test]
        public void IsPrime_Number_3_Test()
        {
            Assert.IsTrue(3.IsPrime());
        }

        [Test]
        public void IsPrime_Number_4_Test()
        {
            Assert.IsFalse(4.IsPrime());
        }

        [Test]
        public void IsPrime_Number_23_Test()
        {
            Assert.IsTrue(23.IsPrime());
        }

        #endregion
    }
}
