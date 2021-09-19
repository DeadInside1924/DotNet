using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Diagnostics.CodeAnalysis;


namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_2Plus5_7Returned()
        {
            //arrange
            var calculator = new Calculator.Calculator();
            var expression = "2 + 5";
            //act
            var result = calculator.Calculate(expression);
            //assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Subtraction_5Minus2_3Returned()
        {
            //arrange
            var calculator = new Calculator.Calculator();
            var expression = "5 - 2";
            //act
            var result = calculator.Calculate(expression);
            //assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Multiplication_5Multiply1_5Returned()
        {
            //arrange
            var calculator = new Calculator.Calculator();
            var expression = "5 * 1";
            //act
            var result = calculator.Calculate(expression);
            //assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Division_5Divide5_1Returned()
        {
            //arrange
            var calculator = new Calculator.Calculator();
            var expression = "5 / 5";
            //act
            var result = calculator.Calculate(expression);
            //assert
            Assert.AreEqual(1, result);
        }
        
        [TestMethod]
        public void Division_5Dot1Divide5Dot1_1Returned()
        {
            //arrange
            var calculator = new Calculator.Calculator();
            var expression = "5.1 / 5.1";
            //act
            
            //assert
            Assert.ThrowsException<System.FormatException>(() => calculator.Calculate(expression));
        }
        
        [TestMethod]
        public void Division_5Comma1Divide5Comma1_1Returned()
        {
            //arrange
            var calculator = new Calculator.Calculator();
            var expression = "5,1 / 5,1";
            //act
            var result = calculator.Calculate(expression);
            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CalculateError_UncorrectExpression()
        {
            //arrange
            var calculator = new Calculator.Calculator();
            var expression = "5,1 / 5,1 + 5";
            //act
            
            //assert
            Assert.ThrowsException<System.Exception>(() => calculator.Calculate(expression));
        }
        
        [TestMethod]
        public void CalculateError_UncorrectOperation()
        {
            //arrange
            var calculator = new Calculator.Calculator();
            var expression = "5,1 ^ 5,1";
            //act
            
            //assert
            Assert.ThrowsException<System.Exception>(() => calculator.Calculate(expression));
        }
    }
}
