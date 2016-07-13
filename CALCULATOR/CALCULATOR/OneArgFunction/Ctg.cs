using System;

namespace CALCULATOR.OneArgFunction
{
    public class Ctg : IOneCalculator
    {
        public double Calculate(double first)
        {
            if (first == 0)
            {
                throw new Exception("");
            }
            return Math.Cos(first)/Math.Sin(first);
        }
    }
}