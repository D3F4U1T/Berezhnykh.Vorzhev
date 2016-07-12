using System;

namespace CALCULATOR
{
    public class Ctg : IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Cos(First)/Math.Sin(First);
        }
    }
}