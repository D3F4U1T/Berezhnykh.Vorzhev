using System;

namespace CALCULATOR
{
    public class Atan2 : ITwoCalculator
    {
        public double Calculate(double First, double Second)
        {
            return Math.Atan2(First, Second);
        }
    }
}