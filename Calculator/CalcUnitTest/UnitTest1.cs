using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2._2;



namespace CalcUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        // Where the Unit Tests for negative numbers?

        [TestMethod]
          [ExpectedException(typeof(DivideByZeroException))]
        public void Calculations_Divide_DivideByZero()
        {
            Calculations myCalc = new Calculations();
            double numerator = 9;
            double denominator = 0;
            
            myCalc.Divide(numerator, denominator);
        }
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Calculations_AddMaxValue_MaxValueOverFlow()
        {
            Calculations myCalc = new Calculations();

            //Usually we would use the "double" alias instead of "Double".
            // underscore "_" is the convention only for private instance fields.
            double _num1 = Double.MaxValue;
            double _num2 = 9;
            myCalc.Add(_num1, _num2);
        }


        [TestMethod]
        public void Calculations_Add2Numbers_DoubleNumbers()
        {
            Calculations myCalc = new Calculations();
            double _num1 = 1;
            double _num2 = 9;
           
            Assert.AreEqual(10, myCalc.Add(_num1, _num2));
        }

        [TestMethod]
        public void Calculations_Substract2Numbers_DoubleNumbers()
        {
            Calculations myCalc = new Calculations();
            double _num1 = 1;
            double _num2 = 9;

            Assert.AreEqual(-8, myCalc.Substract(_num1, _num2));
        }

         [TestMethod]
        public void Calculations_Multiply2Numbers_DoubleNumbers()
        {
            Calculations myCalc = new Calculations();
            double _num1 = 10;
            double _num2 = 9;

            Assert.AreEqual(90, myCalc.Multiply(_num1, _num2));
        }

         [TestMethod]
        public void Calculations_Divide2Numbers_DoubleNumbers()
        {
            Calculations myCalc = new Calculations();
            double _num1 = 18;
            double _num2 = 9;

            Assert.AreEqual(2, myCalc.Divide(_num1, _num2));
        }
    }
}


