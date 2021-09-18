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
        public void ParseDoubleSuccessful()
        {
            //assert
            Assert.AreEqual(1,Parser.ParseToDoubleOrError("1"));
        }

        [TestMethod]
        public void ParseDoubleError()
        {
            //assert
            Assert.ThrowsException<System.Exception>(() => Parser.ParseToDoubleOrError("q"));
        }

        [TestMethod]
        public void ParseOperatorError()
        {
            //assert
            Assert.ThrowsException<System.Exception>(() => Parser.ParseOperatorOrError(":"));
        }

        [TestMethod]
        public void ParseOperatorPlus()
        {
            //assert
            Assert.AreEqual("+", Parser.ParseOperatorOrError("+"));
        }

        [TestMethod]
        public void ParseOperatorMinus()
        {
            //assert
            Assert.AreEqual("-", Parser.ParseOperatorOrError("-"));
        }

        [TestMethod]
        public void ParseOperatorDevision()
        {
            //assert
            Assert.AreEqual("/", Parser.ParseOperatorOrError("/"));
        }

        [TestMethod]
        public void ParseOperatorMultiply()
        {
            //assert
            Assert.AreEqual("*", Parser.ParseOperatorOrError("*"));
        }

        [TestMethod]
        public void CheckError()
        {
            //assert
            Assert.ThrowsException<System.Exception>(() => Parser.CheckOrError(new string[4]));
        }
        
        [TestMethod]
        public void CheckSuccessful()
        {
            string[] args = new[] { "1", "+", "&&&" };
            //assert
            Assert.AreEqual("1",Parser.CheckOrError(args));
        }
    }
}
