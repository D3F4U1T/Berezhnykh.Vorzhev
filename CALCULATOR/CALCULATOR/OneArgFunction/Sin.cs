using System;

namespace CALCULATOR.OneArgFunction
{
    public class Sin : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}