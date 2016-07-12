using System;

namespace CALCULATOR
{
    public class Tan : IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Tan(First);
        }
    }
}