using CSharp.ExtensionMethods.Tests.Helpers;
using NUnit.Framework;
using System;

namespace CSharp.ExtensionMethods.Tests
{
    [TestFixture]
    public class EnumExtensionsTests
    {
        #region GetDescription

        [Test]
        public void GetDescription_Week_Day_Value_Test()
        {
            Duration duration = Duration.Day;
            var description = duration.GetDescription(); // will return "Eight hours"
            Assert.IsTrue("Eight hours" == description);
        }

        [Test]
        public void GetDescription_Week_Enum_Value_Test()
        {
            Duration duration = Duration.Week;
            var description = duration.GetDescription(); // will return "Five days"
            Assert.IsTrue("Five days" == description);
        }

        [Test]
        public void GetDescription_Month_Enum_Value_Test()
        {
            Duration duration = Duration.Month;
            var description = duration.GetDescription(); // will return "Twenty-one days"
            Assert.IsTrue("Twenty-one days" == description);
        }

        [Test]
        public void GetDescription_Half_Year_Enum_Value_Test()
        {
            Duration duration = Duration.HalfYear;
            var description = duration.GetDescription(); // will return ""
            Assert.IsTrue(string.Empty == description);
        }

        [Test]
        public void GetDescription_Year_Enum_Value_Test()
        {
            Duration duration = Duration.Year;
            var description = duration.GetDescription(); // will return null value
            Assert.IsTrue(string.Empty == description);
        }

        #endregion

        #region Count

        [Test]
        public void Count_Empty_Enum_Test()
        {
            var count = Enum<EmptyEnum>.Count;
            Assert.IsTrue(0 == count);
        }

        [Test]
        public void Count_Non_Empty_Enum_Test()
        {
            var count = Enum<Duration>.Count;
            Assert.IsTrue(5 == count);
        }

        [Test]
        public void Count_Invalid_Type_Test()
        {
            Assert.That(() => Enum<DateTime>.Count,
               Throws.TypeOf<ArgumentException>());
        }

        #endregion
    }

}
