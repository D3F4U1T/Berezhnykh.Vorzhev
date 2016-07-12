using System;

namespace CALCULATOR.OneArgFunction
{
    public class Log : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first, 10);
        }
    }
}