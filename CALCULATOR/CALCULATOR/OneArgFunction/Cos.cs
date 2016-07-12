using System;

namespace CALCULATOR
{
    public class Cos : IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Cos(First);
        }
    }
}