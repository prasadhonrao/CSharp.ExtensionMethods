using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.CSharp.Extensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        #region GetOccurrenceCount

        [TestMethod]
        public void Occurence_Valid_Occurence_Test()
        {
            var occurenceCount = "supercalifragilisticexpealidocious".GetOccurrenceCount("li");
            Assert.AreEqual(3, occurenceCount);
        }

        [TestMethod]
        public void Occurence_Invalid_Occurence_Test()
        {
            var occurenceCount = "prasad".GetOccurrenceCount("xxx");
            Assert.AreEqual(0, occurenceCount);
        }

        [TestMethod]
        public void Occurence_EmptyString_Search_Occurence_Test()
        {
            var occurenceCount = "xxx".GetOccurrenceCount(string.Empty);
            Assert.AreEqual(0, occurenceCount);
        }

        [TestMethod]
        public void Occurence_EmptyString_Input_Occurence_Test()
        {
            var occurenceCount = string.Empty.GetOccurrenceCount("Prasad");
            Assert.AreEqual(0, occurenceCount);
        }

        [TestMethod]
        public void Occurence_Empty_Input_Empty_Search_Occurence_Test()
        {
            var occurenceCount = string.Empty.GetOccurrenceCount(string.Empty);
            Assert.AreEqual(1, occurenceCount);
        }

        #endregion

        #region GetWordCount()
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

        #region IsAllLower()

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

        #region IsAllUpper()

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

        #region ToReverseCase()

        [TestMethod]
        public void ToReverseCase_String_Input_Test()
        {
            var result = "AaAaAa".ToReverseCase();
            Assert.AreEqual("aAaAaA", result);
        }

        [TestMethod]
        public void ToReverseCase_UpperCase_String_Input_Test()
        {
            var result = "AAAAA".ToReverseCase();
            Assert.AreEqual("aaaaa", result);
        }

        [TestMethod]
        public void ToReverseCase_LowerCase_String_Input_Test()
        {
            var result = "aaaaa".ToReverseCase();
            Assert.AreEqual("AAAAA", result);
        }

        [TestMethod]
        public void ToReverseCase_Empty_String_Input_Test()
        {
            var result = string.Empty.ToReverseCase();
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToReverseCase_Alphanumeric_String_Input_Test()
        {
            var result = "pras@d".ToReverseCase();
            Assert.AreEqual("PRAS@D", result);
        }

        [TestMethod]
        public void ToReverseCase_Integer_String_Input_Test()
        {
            var result = "1234567890".ToReverseCase();
            Assert.AreEqual("1234567890", result);
        }

        #endregion
     
        #region ToTitleCase()

        [TestMethod]
        public void ToTitleCase_Lower_Case_Input_Test()
        {
            var result = "twinkle twinkle litte star".ToTitleCase();
            Assert.AreEqual("Twinkle twinkle litte star", result);
        }

        [TestMethod]
        public void ToTitleCase_Upper_Case_Input_Test()
        {
            var result = "Twinkle Twinkle Litte Star".ToTitleCase();
            Assert.AreEqual("Twinkle Twinkle Litte Star", result);
        }

        [TestMethod]
        public void ToTitleCase_Empty_String_Input_Test()
        {
            var result = string.Empty.ToTitleCase();
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToTitleCase_Integer_Input_Test()
        {
            var result = "1234567890".ToTitleCase();
            Assert.AreEqual("1234567890", result);
        }

        [TestMethod]
        public void ToTitleCase_Special_Symbol_Input_Test()
        {
            var result = "!@#$%^&*()".ToTitleCase();
            Assert.AreEqual("!@#$%^&*()", result);
        }

        #endregion
    }
}
