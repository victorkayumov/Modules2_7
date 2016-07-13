using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace StringUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //Should add more tests
        [TestMethod]
        public void Check_ReverseString_IsEqual()
        {
            string[] str = new[] { "victor", "kayumov", "was", "here"};

            var splitStr = new ReverseString();
            

            StringAssert.StartsWith("here was kayumov victor", splitStr.ReverseStr(str));
        }

        //You should add more tests for unusuall cases like when an empty string is inputed, when only whitepsaces are inputed and so on
        [TestMethod]
        public void Check_LengthOfString_IsTrue()
        {         
            string strLen = "victor kayumov was here";   
            var len = new Split();

            Assert.AreEqual(4,len.SplitingString(strLen));
        }

        //What about strings with the same words? like "a a a", white about numbers? "0111 1110" ? What about empty arrays?
        //You should add more tests.
        [TestMethod]
        public void Check_SortedString_InRightPlace()
        {
            string[] str = new[] { "victor", "kayumov", "was", "here" };

            var sortedStr = new Sort();


            StringAssert.StartsWith("here kayumov victor was", sortedStr.SortingString(str));
        }

    }

}
