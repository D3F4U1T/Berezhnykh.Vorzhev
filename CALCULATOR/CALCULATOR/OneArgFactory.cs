using System;

namespace CALCULATOR
{
    public static class OneArgFactory
    {
        public static IOneCalculator CreateCalculator(string CalculatorName)
        {
            switch (CalculatorName)
            {
                case "buttonSqrt":
                    return new ClassSqrt();
                case "buttonCos":
                    return new ClassCos();
                case "buttonSin":
                    return new ClassSin();
                case "buttonLn":
                    return new ClassLn();
                default:
                    throw new Exception("I don't no this Operation");

            }
        }
    }
}