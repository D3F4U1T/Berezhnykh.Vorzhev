using System;

namespace CALCULATOR.OneArgFunction
{
    public class Tan : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}