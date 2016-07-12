using System;

namespace CALCULATOR.OneArgFunction
{
    public class Cos : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}