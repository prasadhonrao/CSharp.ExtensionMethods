using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.CSharp.Extensions.Tests
{
    [TestClass]
    public class EnumExtensionsTests
    {
        #region GetDescription

        [TestMethod]
        public void GetDescription_Week_Day_Value_Test()
        {
            Duration duration = Duration.Day;
            var description = duration.GetDescription(); // will return "Eight hours"
            Assert.IsTrue("Eight hours" == description);
        }

        [TestMethod]
        public void GetDescription_Week_Enum_Value_Test()
        {
            Duration duration = Duration.Week;
            var description = duration.GetDescription(); // will return "Five days"
            Assert.IsTrue("Five days" == description);
        }

        [TestMethod]
        public void GetDescription_Month_Enum_Value_Test()
        {
            Duration duration = Duration.Month;
            var description = duration.GetDescription(); // will return "Twenty-one days"
            Assert.IsTrue("Twenty-one days" == description);
        }

        [TestMethod]
        public void GetDescription_Half_Year_Enum_Value_Test()
        {
            Duration duration = Duration.HalfYear;
            var description = duration.GetDescription(); // will return ""
            Assert.IsTrue(string.Empty == description);
        }

        [TestMethod]
        public void GetDescription_Year_Enum_Value_Test()
        {
            Duration duration = Duration.Year;
            var description = duration.GetDescription(); // will return null value
            Assert.IsTrue(string.Empty == description);
        }

        #endregion
    }
}
