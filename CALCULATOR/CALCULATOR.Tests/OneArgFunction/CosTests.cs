using System;
using CALCULATOR.OneArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.OneArgFunction
{


    [TestFixture]
    public class CosTests
    {
        [TestCase(Math.PI, -1 )]
        [TestCase(Math.PI/2, 0)]
        public void CosTest(double first, double expected)
        {
            IOneCalculator calc = new Cos();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.000001);
        }
    }
}