using NUnit.Framework;

namespace CSharp.ExtensionMethods.Tests
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

        #region IsArmstrong

        [Test]
        public void IsArmstrong_0_Test()
        {
            Assert.IsFalse(0.IsArmstrong());
        }

        [Test]
        public void IsArmstrong_5_Test()
        {
            Assert.IsFalse(5.IsArmstrong());
        }

        [Test]
        public void IsArmstrong_371_Test()
        {
            Assert.IsTrue(371.IsArmstrong());
        }

        #endregion

        #region IsPerfect

        [Test]
        public void IsPerfect_Number_0_Test()
        {
            Assert.IsFalse(0.IsPerfect());
        }

        [Test]
        public void IsPerfect_Number_1_Test()
        {
            Assert.IsFalse(1.IsPerfect());
        }

        [Test]
        public void IsPerfect_Number_2_Test()
        {
            Assert.IsFalse(2.IsPerfect());
        }

        [Test]
        public void IsPerfect_Number_6_Test()
        {
            Assert.IsTrue(6.IsPerfect());
        }

        [Test]
        public void IsPerfect_Number_28_Test()
        {
            Assert.IsTrue(28.IsPerfect());
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
        
    }
}
