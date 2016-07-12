using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryDisplay;

namespace UnitTest_2._6
{
    [TestClass]
    public class UnitTest1
    {
        //Where is the testing for negative values?
        //Where is the testing for the number of "1" bits 
        //Where is the testing for special cases like "0"?
        //Where is the testing for wrong arguments like "dfsdf"
        //Where is the testing numbers that are bigger then an integer?
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
