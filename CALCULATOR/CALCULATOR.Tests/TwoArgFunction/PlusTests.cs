using CALCULATOR.TwoArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.TwoArgFunction
{
    [TestFixture]
    public class PlusTests
    {
        [Test]
        public void PlusTest()
        {
            ITwoCalculator calc = new Plus();
            double result = calc.Calculate(3, 5);
            Assert.AreEqual(8,result);
        }
    }
}