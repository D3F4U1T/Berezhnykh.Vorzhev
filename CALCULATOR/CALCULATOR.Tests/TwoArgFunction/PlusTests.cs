﻿using CALCULATOR.TwoArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.TwoArgFunction
{
    [TestFixture]
    public class PlusTests
    {
        [TestCase(6, 2, 8)]
        [TestCase(8, 2, 10)]
        public void PlusTest(double first, double second, double expected)
        {
            ITwoCalculator calc = new Plus();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected,result);
        }
    }
}