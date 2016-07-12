using System;

namespace CALCULATOR
{
    public class Sqrtx : ITwoCalculator
    {
        public double Calculate(double First, double Second)
        {
            return Math.Pow(First, 1/Second);
        }
    }
}