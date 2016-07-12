using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuadNS;

namespace UnitTestQuad
{
    //Where are tests for the actual calculations? You didn't check the logic of your calculation which is the most important thing.
    //It is hard to test it in your code because the architecture you used. You shouldn't return formatted strings or print in calculations.
    [TestClass]
    public class QuadTests
    {
        [TestMethod]
        public void CheckArgs_WhenCalledWith3ValidParameters_ReturnsTrue()
        {
            var quad = new Quad();
            string[] str = { "1", "10", "2" };

            Assert.AreEqual(true, quad.CheckArgs(str));
        }

        //What about a check with no args, with 1 arg or with more than 3?
        [TestMethod]
        public void Test_CheckNot3Args_IsFalse()
        {
            var quad = new Quad();
            string[] str = { "1", "10" };
            Assert.AreEqual(false, quad.CheckArgs(str));
        }
        //_-------------------------------------------------------------_//
        [TestMethod]
        public void Test_CheckParseSuccseded_IsTrue()
        {
            string[] str = { "1", "2", "3" };
            var quad = new Quad();
            double x = 2, y = 8, z = 1;

            Assert.AreEqual(true, quad.CheckParse(str, out x, out y, out z));
        }
        [TestMethod]
        public void Test_CheckParseFaild_IsFalse()
        {
            string[] str = { "1", "10", "xxx" };
            double x = 2, y = 8, z = 1;
            var quad = new Quad();
            Assert.AreEqual(false, quad.CheckParse(str, out x, out y, out z));
        }

        [TestMethod]
        public void Test_NoSolutionWithNegetiveSqrt_IsTrue()
        {
            double toSqrt = -2;
            double x = 2, y = 8, z = 1;
            var quad = new Quad();
            Assert.AreEqual(false, quad.NoSolution(toSqrt, x, y, z));
        }



    }
}
