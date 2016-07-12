using CALCULATOR.TwoArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.TwoArgFunction
{
    [TestFixture]
    public class SqrxyTests
    {
        [TestCase(2, 3, 8)]
        [TestCase(5, 3, 125)]
        public void PlusTest(double first, double second, double expected)
        {
            ITwoCalculator calc = new Sqrxy();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}