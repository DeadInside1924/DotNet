using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CalculatorTest
{
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void ProgramError()
        {
            var args = new[] { "1", "+", "3","+","4" };
            Assert.ThrowsException<System.ArgumentException>(() =>Program.Main(args));
        }
        
    }
}