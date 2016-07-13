using System;
using CALCULATOR.TwoArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.TwoArgFunction
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void DivisionTest()
        {
            ITwoCalculator calc = new Division();
            double result = calc.Calculate(6, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void DivisionByZeroTest()
        {
            ITwoCalculator calculator = new Division();
            Assert.Throws<Exception>(() => calculator.Calculate(1, 0));
        }
    }
}