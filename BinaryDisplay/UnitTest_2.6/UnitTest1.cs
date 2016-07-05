using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryDisplay;

namespace UnitTest_2._6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Convert_IntToBinary_Succseded()
        {
            ConvertToBinary convert = new ConvertToBinary();
            int _num = 8;
            string binary = convert.IntToBinaryString(_num);
            Assert.AreEqual("1000", binary);
        }

        [TestMethod]
        public void CheckParse_IntegerNumber_IsTrue()
        {
            string str = "90";
            var parse = new Program();
            string num = parse.Parse(str);
            Assert.AreEqual("90", str);
        }
    }
}
