using System;

namespace CALCULATOR.TwoArgFunction
{
    public class Atan2 : ITwoCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Atan2(first, second);
        }
    }
}