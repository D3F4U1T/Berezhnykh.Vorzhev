using CALCULATOR.OneArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.OneArgFunction
{
    [TestFixture]
    public class SqrTests
    {
        [TestCase(3, 9)]
        [TestCase(5, 25)]
        public void SqrTest(double first, double expected)
        {
            IOneCalculator calc = new Sqr();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}