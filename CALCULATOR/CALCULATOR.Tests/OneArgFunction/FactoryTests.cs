using System;
using CALCULATOR.OneArgFunction;
using NUnit.Framework;

namespace CALCULATOR.Tests.OneArgFunction
{

    public class FactoryTests
    {
        [TestCase("buttonAbc", typeof(Abc))]
        [TestCase("buttonSqrt", typeof(Sqrt))]
        [TestCase("buttonCos", typeof(Cos))]
        [TestCase("buttonSin", typeof(Sin))]
        [TestCase("buttonLn", typeof(Ln))]
        [TestCase("buttonLog", typeof(Log))]
        [TestCase("buttonSqr", typeof(Sqr))]
        [TestCase("buttonSqrQube", typeof(SqrQube))]
        [TestCase("buttonTan", typeof(Tan))]
        [TestCase("buttonCtg", typeof(Ctg))]
        [TestCase("buttonInverse", typeof(Inverse))]
        [TestCase("buttonExp", typeof(Exp))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}