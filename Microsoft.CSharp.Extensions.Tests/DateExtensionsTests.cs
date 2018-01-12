using System;
using System.Diagnostics;
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

        #region Tomorrow

        [TestMethod]
        public void Tomorrow_Valid_Date_Test()
        {
            var output = new DateTime(2000, 01, 01).Tomorrow();
            int result = DateTime.Compare(output, new DateTime(2000, 01, 02));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Tomorrow_Month_Start_Date_Test()
        {
            var output = new DateTime(2000, 01, 01).Tomorrow();
            int result = DateTime.Compare(output, new DateTime(2000, 01, 02));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Tomorrow_Month_End_Date_Test()
        {
            var output = new DateTime(2000, 01, 31).Tomorrow();
            int result = DateTime.Compare(output, new DateTime(2000, 02, 01));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Tomorrow_Year_Start_Date_Test()
        {
            var output = new DateTime(2000, 01, 01).Tomorrow();
            int result = DateTime.Compare(output, new DateTime(2000, 01, 02));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Tomorrow_Year_End_Date_Test()
        {
            var output = new DateTime(2000, 12, 31).Tomorrow();
            int result = DateTime.Compare(output, new DateTime(2001, 01, 01));
            Assert.AreEqual(0, result);
        }

        #endregion

        #region Yesterday

        [TestMethod]
        public void Yesterday_Valid_Date_Test()
        {
            var output = new DateTime(2000, 01, 02).Yesterday();
            int result = DateTime.Compare(output, new DateTime(2000, 01, 01));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Yesterday_Month_Start_Date_Test()
        {
            var output = new DateTime(2000, 02, 01).Yesterday();
            int result = DateTime.Compare(output, new DateTime(2000, 01, 31));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Yesterday_Month_End_Date_Test()
        {
            var output = new DateTime(2000, 01, 31).Yesterday();
            int result = DateTime.Compare(output, new DateTime(2000, 01, 30));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Yesterday_Year_Start_Date_Test()
        {
            var output = new DateTime(2000, 01, 01).Yesterday();
            int result = DateTime.Compare(output, new DateTime(1999, 12, 31));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Yesterday_Year_End_Date_Test()
        {
            var output = new DateTime(2000, 12, 31).Yesterday();
            int result = DateTime.Compare(output, new DateTime(2000, 12, 30));
            Assert.AreEqual(0, result);
        }

        #endregion

    }
}
