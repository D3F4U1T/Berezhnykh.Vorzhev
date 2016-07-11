using System;
using System.Windows.Forms;

namespace CALCULATOR
{
    public static class TwoArgFactory
    {
        public static ITwoCalculator CreateCalculator(string CalculatorName)
        {
            switch (CalculatorName)
            {
                case "buttonPlus":
                    return new ClassPlus();
                case "buttonMinus":
                    return new ClassMinus();
                case "buttonDivision":
                  return new ClassDivision();
                case "buttonMultiplication":
                    return new ClassMultiplication();
                default:
                    throw new Exception("I don't no this Operation");

            }
        }
    }
}