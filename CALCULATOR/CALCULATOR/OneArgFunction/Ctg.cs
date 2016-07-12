using System;

namespace CALCULATOR.OneArgFunction
{
    public class Ctg : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first)/Math.Sin(first);
        }
    }
}