using NUnit.Framework;

namespace CSharp.ExtensionMethods.Tests
{
    [TestFixture]
    public class DoubleExtensionsTests
    {
        #region ToCurrency

        [Test]
        public void ToCurrency_EN_US_Test()
        {
            double value = 154.20;
            string result = value.ToCurrency("en-US");
            Assert.AreEqual("$154.20", result);
        }

        [Test]
        public void ToCurrency_EN_GB_Test()
        {
            double value = 154.20;
            string result = value.ToCurrency("en-GB");
            Assert.AreEqual("£154.20", result);
        }

        [Test]
        public void ToCurrency_HI_IN_Test()
        {
            double value = 1234.50;
            string result = value.ToCurrency("hi-IN");
            Assert.AreEqual("₹ 1,234.50", result);
        }

        #endregion
    }
}
