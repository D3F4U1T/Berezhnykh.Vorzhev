using System;

namespace CALCULATOR
{
    public class ClassSin : IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Sin(First);
        }
    }
}