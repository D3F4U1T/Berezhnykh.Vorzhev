using CALCULATOR.TwoArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.TwoArgFunction
{
    [TestFixture]
    public class MinusTests
    {
            [Test]
            public void MinusTest()
            {
                ITwoCalculator calc = new Minus();
                double result = calc.Calculate(5, 3);
                Assert.AreEqual(2, result);
            }
        }
    }