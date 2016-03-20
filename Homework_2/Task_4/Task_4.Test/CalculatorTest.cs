using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorNameSpace;

namespace CalculatorNameSpace.Test
{
    [TestClass]
    public class CalculatorTest
    {
        private Calculator calculator;
        private IStack stack = new ListStack();

        [TestInitialize]
        public void Initialize()
        {
            calculator = new Calculator(stack);
        }

        [TestMethod]
        public void AdditionTest()
        {
            calculator.Push(1);
            calculator.Push(2);
            calculator.Addition();
            Assert.AreEqual(calculator.Result(), 3);
        }

        [TestMethod]
        public void SubstractionTest()
        {
            calculator.Push(2);
            calculator.Push(-1);
            calculator.Subtraction();
            Assert.AreEqual(calculator.Result(), 3);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            calculator.Push(2);
            calculator.Push(5);
            calculator.Multiplication();
            Assert.AreEqual(calculator.Result(), 10);
        }

        [TestMethod]
        public void DivisionTest()
        {
            calculator.Push(4);
            calculator.Push(2);
            calculator.Division();
            Assert.AreEqual(calculator.Result(), 2);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionByZeroTest()
        {
            calculator.Push(1);
            calculator.Push(0);
            calculator.Division();
        }
    }
}
