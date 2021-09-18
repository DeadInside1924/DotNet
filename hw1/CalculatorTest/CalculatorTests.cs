using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;


namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_2Plus5_7Returned()
        {
            //act
            var result = Calculator.Calculator.Calculate(5,2,"+");

            //assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Subtraction_5Minus2_3Returned()
        {
            //act
            var result = Calculator.Calculator.Calculate(5, 2, "-");

            //assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Multiplication_5Multiply1_5Returned()
        {
            //act
            var result = Calculator.Calculator.Calculate(5, 1, "*");

            //assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Division_5Divide5_1Returned()
        {
            //act
            var result = Calculator.Calculator.Calculate(5, 5, "/");

            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CalculateError()
        {
            //assert
            Assert.ThrowsException<System.Exception>(() => Calculator.Calculator.Calculate(5, 5, "^"));
        }
    }
}
