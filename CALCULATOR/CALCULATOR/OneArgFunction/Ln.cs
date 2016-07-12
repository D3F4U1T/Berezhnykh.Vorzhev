using System;

namespace CALCULATOR.OneArgFunction
{
    public class Ln : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first,Math.E);
        }
    }
}