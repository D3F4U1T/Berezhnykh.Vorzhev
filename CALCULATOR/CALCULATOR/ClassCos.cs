using System;

namespace CALCULATOR
{
    public class ClassCos : IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Cos(First);
        }
    }
}