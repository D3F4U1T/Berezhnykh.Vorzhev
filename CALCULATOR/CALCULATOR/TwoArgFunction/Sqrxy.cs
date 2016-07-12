using System;

namespace CALCULATOR
{
    public class Sqrxy : ITwoCalculator
    {
        public double Calculate(double First, double Second)
        {
            return Math.Pow(First, Second);
        }
    }
}