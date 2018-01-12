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

        #region IsWeekday

        [TestMethod]
        public void IsWeekday_Monday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 01).IsWeekday();
            Assert.IsTrue(isWeekday);
        }

        [TestMethod]
        public void IsWeekday_Tuesday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 02).IsWeekday();
            Assert.IsTrue(isWeekday);
        }

        [TestMethod]
        public void IsWeekday_Wednesday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 03).IsWeekday();
            Assert.IsTrue(isWeekday);
        }

        [TestMethod]
        public void IsWeekday_Thrusday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 04).IsWeekday();
            Assert.IsTrue(isWeekday);
        }

        [TestMethod]
        public void IsWeekday_Friday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 05).IsWeekday();
            Assert.IsTrue(isWeekday);
        }

        [TestMethod]
        public void IsWeekday_Saturday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 06).IsWeekday();
            Assert.IsFalse(isWeekday);
        }

        [TestMethod]
        public void IsWeekday_Sunday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 07).IsWeekday();
            Assert.IsFalse(isWeekday);
        }

        #endregion

        #region IsWeekend

        [TestMethod]
        public void IsWeekend_Saturday_Test()
        {
            var isWeekend = new DateTime(2018, 01, 06).IsWeekend();
            Assert.IsTrue(isWeekend);
        }

        [TestMethod]
        public void IsWeekend_Sunday_Test()
        {
            var isWeekend = new DateTime(2018, 01, 07).IsWeekend();
            Assert.IsTrue(isWeekend);
        }

        [TestMethod]
        public void IsWeekend_Monday_Test()
        {
            var isWeekend = new DateTime(2018, 01, 08).IsWeekend();
            Assert.IsFalse(isWeekend);
        }

        #endregion

        #region NextBusinessDay

        [TestMethod]
        public void NextBusinessDay_Weekday_Test()
        {
            var day = new DateTime(2018, 01, 01).NextBusinessDay();
            int result = DateTime.Compare(day, new DateTime(2018, 01, 02));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void NextBusinessDay_Saturday_Test()
        {
            var day = new DateTime(2018, 01, 06).NextBusinessDay();
            int result = DateTime.Compare(day, new DateTime(2018, 01, 08));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void NextBusinessDay_Sunday_Test()
        {
            var day = new DateTime(2018, 01, 07).NextBusinessDay();
            int result = DateTime.Compare(day, new DateTime(2018, 01, 08));
            Assert.AreEqual(0, result);
        }

        #endregion

        #region PreviousBusinessDay

        [TestMethod]
        public void PreviousBusinessDay_Weekday_Test()
        {
            var day = new DateTime(2018, 01, 02).PreviousBusinessDay();
            int result = DateTime.Compare(day, new DateTime(2018, 01, 01));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void PreviousBusinessDay_Saturday_Test()
        {
            var day = new DateTime(2018, 01, 06).PreviousBusinessDay();
            int result = DateTime.Compare(day, new DateTime(2018, 01, 05));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void PreviousBusinessDay_Sunday_Test()
        {
            var day = new DateTime(2018, 01, 07).PreviousBusinessDay();
            int result = DateTime.Compare(day, new DateTime(2018, 01, 05));
            Assert.AreEqual(0, result);
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
