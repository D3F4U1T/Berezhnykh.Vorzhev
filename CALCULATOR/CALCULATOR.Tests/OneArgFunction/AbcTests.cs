using CALCULATOR.OneArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.OneArgFunction
{
    [TestFixture]
    public class AbcTests
    {
        [TestCase(-6, 6)]
        [TestCase(-8, 2)]
        public void PlusTest(double first, double expected)
        {
            IOneCalculator calc = new Abc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}