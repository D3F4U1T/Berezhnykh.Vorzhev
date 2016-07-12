using System;

namespace CALCULATOR
{
    public class Log : IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Log(First, 10);
        }
    }
}