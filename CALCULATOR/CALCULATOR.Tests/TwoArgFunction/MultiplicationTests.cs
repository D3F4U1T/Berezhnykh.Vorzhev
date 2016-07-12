using CALCULATOR.TwoArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.TwoArgFunction
{
    [TestFixture]
    public class MultiplicationTests
    {
        [Test]
            public void MultiplicationTest()
            {
                ITwoCalculator calc = new Multiplication();
                double result = calc.Calculate(3, 3);
                Assert.AreEqual(9, result);
            }
    }
}