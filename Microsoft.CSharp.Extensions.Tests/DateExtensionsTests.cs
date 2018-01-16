using NUnit.Framework;
using System;

namespace Microsoft.CSharp.Extensions.Tests
{
    [TestFixture]
    public class DateExtensionsTests
    {
        #region GetFirstDayOfWeek

        [Test]
        public void GetFirstDayOfWeek_1st_Test()
        {
            var firstDay = new DateTime(2018, 01, 01).GetFirstDayOfWeek();
            int result = DateTime.Compare(firstDay, new DateTime(2017, 12, 31));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GetFirstDayOfWeek_2nd_Test()
        {
            var firstDay = new DateTime(2018, 01, 31).GetFirstDayOfWeek();
            int result = DateTime.Compare(firstDay, new DateTime(2018, 01, 28));
            Assert.AreEqual(0, result);
        }

        #endregion

        #region GetLastDayOfWeek

        [Test]
        public void GetLastDayOfWeek_1st_Test()
        {
            var firstDay = new DateTime(2018, 01, 01).GetLastDayOfWeek();
            int result = DateTime.Compare(firstDay, new DateTime(2018, 01, 06));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GetLastDayOfWeek_2nd_Test()
        {
            var firstDay = new DateTime(2018, 01, 31).GetLastDayOfWeek();
            int result = DateTime.Compare(firstDay, new DateTime(2018, 02, 03));
            Assert.AreEqual(0, result);
        }

        #endregion

        #region GetOrdinalSuffix

        [Test]
        public void GetOrdinalSuffix_1st_Test()
        {
            var input = new DateTime(2000, 01, 01).GetOrdinalSuffix();
            Assert.IsTrue(input == "1st");
        }

        [Test]
        public void GetOrdinalSuffix_2nd_Test()
        {
            var input = new DateTime(2000, 01, 02).GetOrdinalSuffix();
            Assert.IsTrue(input == "2nd");
        }

        [Test]
        public void GetOrdinalSuffix_3rd_Test()
        {
            var input = new DateTime(2000, 01, 03).GetOrdinalSuffix();
            Assert.IsTrue(input == "3rd");
        }

        [Test]
        public void GetOrdinalSuffix_4th_Test()
        {
            var input = new DateTime(2000, 01, 04).GetOrdinalSuffix();
            Assert.IsTrue(input == "4th");
        }

        [Test]
        public void GetOrdinalSuffix_11th_Test()
        {
            var input = new DateTime(2000, 01, 11).GetOrdinalSuffix();
            Assert.IsTrue(input == "11th");
        }

        #endregion

        #region IsWeekday

        [Test]
        public void IsWeekday_Monday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 01).IsWeekday();
            Assert.IsTrue(isWeekday);
        }

        [Test]
        public void IsWeekday_Tuesday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 02).IsWeekday();
            Assert.IsTrue(isWeekday);
        }

        [Test]
        public void IsWeekday_Wednesday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 03).IsWeekday();
            Assert.IsTrue(isWeekday);
        }

        [Test]
        public void IsWeekday_Thrusday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 04).IsWeekday();
            Assert.IsTrue(isWeekday);
        }

        [Test]
        public void IsWeekday_Friday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 05).IsWeekday();
            Assert.IsTrue(isWeekday);
        }

        [Test]
        public void IsWeekday_Saturday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 06).IsWeekday();
            Assert.IsFalse(isWeekday);
        }

        [Test]
        public void IsWeekday_Sunday_Test()
        {
            var isWeekday = new DateTime(2018, 01, 07).IsWeekday();
            Assert.IsFalse(isWeekday);
        }

        #endregion

        #region IsWeekend

        [Test]
        public void IsWeekend_Saturday_Test()
        {
            var isWeekend = new DateTime(2018, 01, 06).IsWeekend();
            Assert.IsTrue(isWeekend);
        }

        [Test]
        public void IsWeekend_Sunday_Test()
        {
            var isWeekend = new DateTime(2018, 01, 07).IsWeekend();
            Assert.IsTrue(isWeekend);
        }

        [Test]
        public void IsWeekend_Monday_Test()
        {
            var isWeekend = new DateTime(2018, 01, 08).IsWeekend();
            Assert.IsFalse(isWeekend);
        }

        #endregion

        #region NextWeekDay

        [Test]
        public void NextWeekDay_Weekday_Test()
        {
            var day = new DateTime(2018, 01, 01).NextWeekDay();
            int result = DateTime.Compare(day, new DateTime(2018, 01, 02));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void NextWeekDay_Saturday_Test()
        {
            var day = new DateTime(2018, 01, 06).NextWeekDay();
            int result = DateTime.Compare(day, new DateTime(2018, 01, 08));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void NextWeekDay_Sunday_Test()
        {
            var day = new DateTime(2018, 01, 07).NextWeekDay();
            int result = DateTime.Compare(day, new DateTime(2018, 01, 08));
            Assert.AreEqual(0, result);
        }

        #endregion

        #region PreviousWeekDay

        [Test]
        public void PreviousWeekDay_Weekday_Test()
        {
            var day = new DateTime(2018, 01, 02).PreviousWeekDay();
            int result = DateTime.Compare(day, new DateTime(2018, 01, 01));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void PreviousWeekDay_Saturday_Test()
        {
            var day = new DateTime(2018, 01, 06).PreviousWeekDay();
            int result = DateTime.Compare(day, new DateTime(2018, 01, 05));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void PreviousWeekDay_Sunday_Test()
        {
            var day = new DateTime(2018, 01, 07).PreviousWeekDay();
            int result = DateTime.Compare(day, new DateTime(2018, 01, 05));
            Assert.AreEqual(0, result);
        }

        #endregion

        #region Tomorrow

        [Test]
        public void Tomorrow_Valid_Date_Test()
        {
            var output = new DateTime(2000, 01, 01).Tomorrow();
            int result = DateTime.Compare(output, new DateTime(2000, 01, 02));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Tomorrow_Month_Start_Date_Test()
        {
            var output = new DateTime(2000, 01, 01).Tomorrow();
            int result = DateTime.Compare(output, new DateTime(2000, 01, 02));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Tomorrow_Month_End_Date_Test()
        {
            var output = new DateTime(2000, 01, 31).Tomorrow();
            int result = DateTime.Compare(output, new DateTime(2000, 02, 01));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Tomorrow_Year_Start_Date_Test()
        {
            var output = new DateTime(2000, 01, 01).Tomorrow();
            int result = DateTime.Compare(output, new DateTime(2000, 01, 02));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Tomorrow_Year_End_Date_Test()
        {
            var output = new DateTime(2000, 12, 31).Tomorrow();
            int result = DateTime.Compare(output, new DateTime(2001, 01, 01));
            Assert.AreEqual(0, result);
        }

        #endregion

        #region Yesterday

        [Test]
        public void Yesterday_Valid_Date_Test()
        {
            var output = new DateTime(2000, 01, 02).Yesterday();
            int result = DateTime.Compare(output, new DateTime(2000, 01, 01));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Yesterday_Month_Start_Date_Test()
        {
            var output = new DateTime(2000, 02, 01).Yesterday();
            int result = DateTime.Compare(output, new DateTime(2000, 01, 31));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Yesterday_Month_End_Date_Test()
        {
            var output = new DateTime(2000, 01, 31).Yesterday();
            int result = DateTime.Compare(output, new DateTime(2000, 01, 30));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Yesterday_Year_Start_Date_Test()
        {
            var output = new DateTime(2000, 01, 01).Yesterday();
            int result = DateTime.Compare(output, new DateTime(1999, 12, 31));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Yesterday_Year_End_Date_Test()
        {
            var output = new DateTime(2000, 12, 31).Yesterday();
            int result = DateTime.Compare(output, new DateTime(2000, 12, 30));
            Assert.AreEqual(0, result);
        }

        #endregion

    }
}
