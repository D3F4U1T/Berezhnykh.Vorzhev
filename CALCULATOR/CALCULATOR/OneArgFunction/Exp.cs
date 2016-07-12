using System;

namespace CALCULATOR.OneArgFunction
{
    public class Exp : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}