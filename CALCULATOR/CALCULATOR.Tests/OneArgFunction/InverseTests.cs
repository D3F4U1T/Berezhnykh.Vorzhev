using CALCULATOR.OneArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.OneArgFunction
{
    [TestFixture]
    public class InverseTests
    {
        [TestCase(-1, 1)]
        [TestCase(3, -3)]
        public void InverseTest(double first, double expected)
        {
            IOneCalculator calc = new Inverse();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}