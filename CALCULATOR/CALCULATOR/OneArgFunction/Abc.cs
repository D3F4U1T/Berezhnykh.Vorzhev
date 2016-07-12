using System;

namespace CALCULATOR.OneArgFunction
{
    public class Abc : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}