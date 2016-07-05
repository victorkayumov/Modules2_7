using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuadNS;

namespace UnitTestQuad
{
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
