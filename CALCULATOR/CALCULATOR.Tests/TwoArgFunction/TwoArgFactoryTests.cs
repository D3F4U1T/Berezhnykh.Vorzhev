using System;
using CALCULATOR.OneArgFunction;
using CALCULATOR.TwoArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.TwoArgFunction
{
    public class TwoArgFactoryTests
    {

          [TestCase("buttonPlus", typeof(Plus))]
          [TestCase("buttonMinus", typeof(Minus))]
          [TestCase("buttonDivision", typeof(Division))]
          [TestCase("buttonMultiplication", typeof(Multiplication))]
          [TestCase("buttonLogTwoArg", typeof(ClassLog))]
          [TestCase("buttonSqrxy", typeof(Sqrxy))]
          [TestCase("buttonAtan2", typeof(Atan2))]
          [TestCase("buttonSqrtx", typeof(Sqrtx))]
        public void CalculateTest(string name, Type type)
{
var calculator = TwoArgFactory.CreateCalculator(name);

Assert.IsInstanceOf(type, calculator);
}

    }
}
    