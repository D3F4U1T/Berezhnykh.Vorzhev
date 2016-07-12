using System;

namespace CALCULATOR.TwoArgFunction
{
    public class Sqrxy : ITwoCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}