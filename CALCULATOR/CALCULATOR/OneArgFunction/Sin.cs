using System;

namespace CALCULATOR
{
    public class Sin : IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Sin(First);
        }
    }
}