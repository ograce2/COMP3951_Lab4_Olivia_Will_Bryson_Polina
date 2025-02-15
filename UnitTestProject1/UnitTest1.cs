using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP3951_Lab2_Olivia_Grace_Jason_Peacock;
using System;
using System.Diagnostics;

namespace UnitTestProject1
{

    [TestClass]
    public class UnitTest1
    {
        private Calculator calculator;

        [TestInitialize]
        public void InitCalc()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void TestAddition()
        {
            calculator.setOperand(2);
            calculator.setOperation("+");
            calculator.setOperand(8);
            double? result = calculator.performCalculation();
            Assert.AreEqual(10, result, "2 + 8 should be 10!");
        }

        [TestMethod]
        public void TestSubtraction()
        {
            calculator.setOperand(10);
            calculator.setOperation("-");
            calculator.setOperand(2);
            double? result = calculator.performCalculation();
            Assert.AreEqual(2, result, "10 - 8 should be 2!");
        }
    }
}
