using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.CSharp.Extensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        #region ToInt()
        [TestMethod]
        public void ToInt_Valid_String_To_Int_Test()
        {
            var input = "100".ToInt();
            Assert.IsTrue(input == 100);
        }

        [TestMethod]
        public void ToInt_Invalid_String_To_Int_Test()
        {
            var input = "AAA".ToInt();
            Assert.IsTrue(input == 0);
        }

        [TestMethod]
        public void ToInt_Empty_String_To_Int_Test()
        {
            var input = string.Empty.ToInt();
            Assert.IsTrue(input == 0);
        }

        [TestMethod]
        public void ToInt_Special_Symbol_To_Int_Test()
        {
            var input = "!@#$%^".ToInt();
            Assert.IsTrue(input == 0);
        }
        #endregion

        #region GetWordCount
        [TestMethod]
        public void GetWordCount_With_String_Input_Test()
        {
            var result = "My name is Prasad Honrao".GetWordCount();
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void GetWordCount_With_String_With_Special_Symbol_Input_Test()
        {
            var result = "@#@#@# My @name @is @Prasad @Honrao @#@#@#".GetWordCount();
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void GetWordCount_Blank_String_Test()
        {
            var result = "".GetWordCount();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetWordCount_Long_Blank_String_Test()
        {
            var result = "        ".GetWordCount();
            Assert.AreEqual(0, result);
        }
        #endregion

        #region IsAllUpper

        [TestMethod]
        public void IsAllUpper_UpperCase_String_Input_Test()
        {
            var result = "TWINKLE TWINKLE LITTE STAR".IsAllUpper();
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsAllUpper_MixedCase_String_Input_Test()
        {
            var result = "Twinkle Twinkle Litte Star".IsAllUpper();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsAllUpper_Integer_String_Input_Test()
        {
            var result = "1234567890".IsAllUpper();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsAllUpper_Special_Symbol_String_Input_Test()
        {
            var result = "!@#$%^&*()".IsAllUpper();
            Assert.AreEqual(false, result);
        }

        #endregion

        #region IsAllLower

        [TestMethod]
        public void IsAllLower_LowerCase_String_Input_Test()
        {
            var result = "twinkle twinkle litte star".IsAllLower();
            Assert.AreEqual(true, result);
        }
        
        [TestMethod]
        public void IsAllLower_MixedCase_String_Input_Test()
        {
            var result = "Twinkle Twinkle Litte Star".IsAllLower();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsAllLower_Integer_String_Input_Test()
        {
            var result = "1234567890".IsAllLower();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsAllLower_Special_Symbol_String_Input_Test()
        {
            var result = "!@#$%^&*()".IsAllLower();
            Assert.AreEqual(false, result);
        }

        #endregion
    }
}
