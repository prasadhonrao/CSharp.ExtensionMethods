using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.CSharp.Extensions.Tests
{
    [TestClass]
    public class DateExtensionsTests
    {
        #region GetOrdinalSuffix

        [TestMethod]
        public void GetOrdinalSuffix_1st_Test()
        {
            var input = new DateTime(2000, 01, 01).GetOrdinalSuffix();
            Assert.IsTrue(input == "1st");
        }

        [TestMethod]
        public void GetOrdinalSuffix_2nd_Test()
        {
            var input = new DateTime(2000, 01, 02).GetOrdinalSuffix();
            Assert.IsTrue(input == "2nd");
        }

        [TestMethod]
        public void GetOrdinalSuffix_3rd_Test()
        {
            var input = new DateTime(2000, 01, 03).GetOrdinalSuffix();
            Assert.IsTrue(input == "3rd");
        }

        [TestMethod]
        public void GetOrdinalSuffix_4th_Test()
        {
            var input = new DateTime(2000, 01, 04).GetOrdinalSuffix();
            Assert.IsTrue(input == "4th");
        } 

        #endregion
    }
}
