using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void ParseOperationError()
        {
            Parser parser = new Parser("5 ^ 5");
            //assert
            Assert.ThrowsException<System.Exception>(() =>parser.Operation);
        }

        [TestMethod]
        public void ParseOperationPlus()
        {
            Parser parser = new Parser("5 + 5");
            //assert
            Assert.AreEqual("+", parser.Operation);
        }

        [TestMethod]
        public void ParseOperationMinus()
        {
            Parser parser = new Parser("5 - 5");
            //assert
            Assert.AreEqual("-", parser.Operation);
        }

        [TestMethod]
        public void ParseOperatorDevision()
        {
            Parser parser = new Parser("5 / 5");
            //assert
            Assert.AreEqual("/", parser.Operation);
        }

        [TestMethod]
        public void ParseOperatorMultiply()
        {
            Parser parser = new Parser("5 * 5");
            //assert
            Assert.AreEqual("*",parser.Operation);
        }

        [TestMethod]
        public void ParseValue1Successful()
        {
            Parser parser = new Parser("5 + 5");
            //assert
            Assert.AreEqual(5,parser.Value1);
        }
        
        [TestMethod]
        public void ParseValue1Error()
        {
            Parser parser = new Parser("q + 5");
            //assert
            Assert.ThrowsException<System.Exception>(() =>parser.Value1);
        }
        
        [TestMethod]
        public void ParseValue2Successful()
        {
            Parser parser = new Parser("5 + 5");
            //assert
            Assert.AreEqual(5,parser.Value2);
        }
        
        [TestMethod]
        public void ParseValue2Error()
        {
            Parser parser = new Parser("5 + q");
            //assert
            Assert.ThrowsException<System.Exception>(() =>parser.Value2);
        }
    }
}
