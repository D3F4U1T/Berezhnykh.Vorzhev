using System;
using CALCULATOR.OneArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.OneArgFunction
{
     [TestFixture]
    public class CtgTests
    {
        [TestCase(Math.PI/4, 1)]
        [TestCase(Math.PI/2, 0)]
        public void CtgTest(double first, double expected)
        {
            IOneCalculator calc = new Ctg();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.000001);
        }
        [Test]
        public void CtgByZeroTest()
        {
            IOneCalculator calculator = new Ctg();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}
    
