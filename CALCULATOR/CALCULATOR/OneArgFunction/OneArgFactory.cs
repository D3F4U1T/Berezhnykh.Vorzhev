using System;

namespace CALCULATOR.OneArgFunction
{
    public static class OneArgFactory
    {
        public static IOneCalculator CreateCalculator(string CalculatorName)
        {
            switch (CalculatorName)
            {
                case "buttonSqrt":
                    return new Sqrt();
                case "buttonCos":
                    return new Cos();
                case "buttonSin":
                    return new Sin();
                case "buttonLn":
                    return new Ln();
                case "buttonLog":
                    return new Log();
                case "buttonSqr":
                    return new Sqr();
                case "buttonSqrQube":
                    return new SqrQube();
                case "buttonTan":
                    return new Tan();
                case "buttonCtg":
                    return new Ctg();
                case "buttonInverse":
                    return new Inverse();
                case "buttonAbc":
                    return new Abc();
                case "buttonExp":
                    return new Exp();

                default:
                    throw new Exception("I don't know this operation");

            }
        }
    }
}