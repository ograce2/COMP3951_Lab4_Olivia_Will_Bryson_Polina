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
        private Form1 form1;

        [TestInitialize]
        public void InitCalc()
        {
            calculator = new Calculator();
            form1 = new Form1();
            
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
            calculator.setOperand(8);
            double? result = calculator.performCalculation();
            Assert.AreEqual(2, result, "10 - 8 should be 2!");
        }


        [TestMethod]
        public void TestMultiplication()
        {
            calculator.setOperand(10);
            calculator.setOperation("*");
            calculator.setOperand(8);
            double? result = calculator.performCalculation();
            Assert.AreEqual(80, result, "10 * 8 should be 80!");
        }

        [TestMethod]
        public void TestDivision()
        {
            calculator.setOperand(40);
            calculator.setOperation("/");
            calculator.setOperand(8);
            double? result = calculator.performCalculation();
            Assert.AreEqual(5, result, "40 / 8 should be 5!");
        }

        [TestMethod]
        public void TestPercent()
        {
            calculator.setOperand(10);
            calculator.setOperation("%");
            calculator.setOperand(8);
            double? result = calculator.performCalculation();
            Assert.AreEqual(0.8, result, "10 % 8 should be 0.8!");
        }


        [TestMethod]
        public void TestInverse()
        {
            calculator.setOperand(2);
            calculator.setOperation("1/x");
            double? result = calculator.performCalculation();
            Assert.AreEqual(0.5, result, "1 / 2 should be 0.5!");
        }

        [TestMethod]
        public void TestSquared()
        {
            calculator.setOperand(2);
            calculator.setOperation("x^2");
            double? result = calculator.performCalculation();
            Assert.AreEqual(4, result, "2 ^ 2 should be 4!");
        }

        [TestMethod]
        public void TestSquareRoot()
        {
            calculator.setOperand(4);
            calculator.setOperation("sqrt");
            double? result = calculator.performCalculation();
            Assert.AreEqual(2, result, "sqrt(4) should be 2!");
        }

        [TestMethod]
        public void TestMemoryAdd()
        {
            form1.ResetCalculator();
            form1.handleNumericInput("10");
            form1.MemoryAdd();
            Assert.AreEqual(10, form1.GetCalculator().Memory, "Memory should be 10!");
        }

        [TestMethod]
        public void TestMemoryClear()
        {
            form1.ResetCalculator();
            form1.handleNumericInput("10");
            form1.MemoryClear();
            Assert.AreEqual(0, form1.GetCalculator().Memory, "Memory should be 0!");
        }

        [TestMethod]
        public void TestMemoryAssign()
        {
            form1.ResetCalculator();
            form1.GetCalculator().Memory = 20;
            form1.handleNumericInput("10");
            form1.MemoryAssign();
            Assert.AreEqual(10, form1.GetCalculator().Memory, "Memory should be 10!");
        }

        [TestMethod]
        public void TestDivideByZero()
        {
            calculator.setOperand(40);
            calculator.setOperation("/");
            calculator.setOperand(0);
            Assert.ThrowsException<DivideByZeroException>(() => calculator.performCalculation());

        }

    }
}
