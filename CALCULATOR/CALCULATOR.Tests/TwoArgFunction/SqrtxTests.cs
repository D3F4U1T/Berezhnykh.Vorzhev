using CALCULATOR.TwoArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.TwoArgFunction
{
    [TestFixture]
    public class SqrtxTests
    {

        [TestCase(8, 3, 2)]
        [TestCase(25, 2, 5)]
        public void SqrtxTest(double first, double second, double expected)
        {
            ITwoCalculator calc = new Sqrtx();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}