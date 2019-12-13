using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirma.Uzduotis;
using Pirma.Uzduotis.Controller;
using Pirma.Uzduotis.Interface;

namespace UnitTests
{
    [TestClass]
    public class TestOutput
    {
        private ICalculator _calculator;

        [TestInitialize]
        public void TestInitialize()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void CalculateAngle_0H_0MM()
        {
            Assert.AreEqual(0, _calculator.CalculateAngle(0, 0));
        }

        [TestMethod]
        public void CalculateAngle_0H_00MM()
        {
            Assert.AreEqual(0, _calculator.CalculateAngle(0, 00));
        }

        [TestMethod]
        public void CalculateAngle_12H_0MM()
        {
            Assert.AreEqual(0, _calculator.CalculateAngle(12, 0));
        }

        [TestMethod]
        public void CalculateAngle_12H_30MM()
        {
            Assert.AreEqual(165, _calculator.CalculateAngle(12, 30));
        }

        [TestMethod]
        public void CalculateAngle_0H_30MM()
        {
            Assert.AreEqual(165, _calculator.CalculateAngle(0, 30));
        }

        [TestMethod]
        public void CalculateAngle_00H_30MM()
        {
            Assert.AreEqual(165, _calculator.CalculateAngle(00, 30));
        }
    }
}
