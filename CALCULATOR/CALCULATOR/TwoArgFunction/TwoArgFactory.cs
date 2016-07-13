using System;

namespace CALCULATOR.TwoArgFunction
{
    public static class TwoArgFactory
    {
        public static ITwoCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "buttonPlus":
                    return new Plus();
                case "buttonMinus":
                    return new Minus();
                case "buttonDivision":
                  return new Division();
                case "buttonMultiplication":
                    return new Multiplication();
                case "buttonLogTwoArg":
                    return new ClassLog();
                case "buttonSqrxy":
                    return new Sqrxy();
                case "buttonAtan2":
                    return new Atan2();
                case "buttonSqrtx":
                    return new Sqrtx();
                default:
                    throw new Exception("I don't know this Operation");

            }
        }
    }
}