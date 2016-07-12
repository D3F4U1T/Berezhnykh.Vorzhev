using System;

namespace CALCULATOR
{
    public class Abc : IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Abs(First);
        }
    }
}