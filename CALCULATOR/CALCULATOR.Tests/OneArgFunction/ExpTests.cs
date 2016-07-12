using CALCULATOR.OneArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.OneArgFunction
{
    [TestFixture]
    public class ExpTests
    {
      
    
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void PlusTest(double first, double expected)
        {
            IOneCalculator calc = new Abc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}