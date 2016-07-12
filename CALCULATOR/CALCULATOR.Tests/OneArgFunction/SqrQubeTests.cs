using CALCULATOR.OneArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.OneArgFunction
{
    [TestFixture]
    public class SqrQubeTests
    {
        [TestCase(3, 27)]
        [TestCase(5, 125)]
        public void SqrQubeTest(double first, double expected)
        {
            IOneCalculator calc = new SqrQube();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}