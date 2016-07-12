using System;

namespace CALCULATOR.TwoArgFunction
{
    public class Sqrtx : ITwoCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, 1/second);
        }
    }
}