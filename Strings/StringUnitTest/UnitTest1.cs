using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace StringUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_ReverseString_IsEqual()
        {
            string[] str = new[] { "victor", "kayumov", "was", "here"};

            var splitStr = new ReverseString();
            

            StringAssert.StartsWith("here was kayumov victor", splitStr.ReverseStr(str));
        }

        [TestMethod]
        public void Check_LengthOfString_IsTrue()
        {         
            string strLen = "victor kayumov was here";   
            var len = new Split();

            Assert.AreEqual(4,len.SplitingString(strLen));
        }

        [TestMethod]
        public void Check_SortedString_InRightPlace()
        {
            string[] str = new[] { "victor", "kayumov", "was", "here" };

            var sortedStr = new Sort();


            StringAssert.StartsWith("here kayumov victor was", sortedStr.SortingString(str));
        }

    }

}
