using System;

namespace CALCULATOR.OneArgFunction
{
    public class Sqrt: IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first); 
        }
    }
}