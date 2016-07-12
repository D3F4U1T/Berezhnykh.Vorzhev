using System;

namespace CALCULATOR
{
    public class Ln : IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Log(First,Math.E);
        }
    }
}