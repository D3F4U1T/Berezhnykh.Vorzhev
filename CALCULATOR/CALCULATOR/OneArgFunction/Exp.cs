using System;

namespace CALCULATOR
{
    public class Exp : IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Exp(First);
        }
    }
}