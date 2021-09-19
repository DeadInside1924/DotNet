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
            Calculator.Calculator calculator = new Calculator.Calculator("2 + 5");

            //assert
            Assert.AreEqual(7, calculator.Calculate());
        }

        [TestMethod]
        public void Subtraction_5Minus2_3Returned()
        {
            //act
            Calculator.Calculator calculator = new Calculator.Calculator("5 - 2");

            //assert
            Assert.AreEqual(3, calculator.Calculate());
        }

        [TestMethod]
        public void Multiplication_5Multiply1_5Returned()
        {
            //act
            Calculator.Calculator calculator = new Calculator.Calculator("5 * 1");

            //assert
            Assert.AreEqual(5, calculator.Calculate());
        }

        [TestMethod]
        public void Division_5Divide5_1Returned()
        {
            //act
            Calculator.Calculator calculator = new Calculator.Calculator("5 / 5");

            //assert
            Assert.AreEqual(1, calculator.Calculate());
        }

        [TestMethod]
        public void CalculateError()
        {
            Calculator.Calculator calculator = new Calculator.Calculator("5 ^ 5");
            //assert
            Assert.ThrowsException<System.Exception>(() => calculator.Calculate());
        }
    }
}
