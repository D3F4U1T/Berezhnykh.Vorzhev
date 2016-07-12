using System;

namespace CALCULATOR
{
    public class ClassLn : IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Log(First,Math.E);
        }
    }
}