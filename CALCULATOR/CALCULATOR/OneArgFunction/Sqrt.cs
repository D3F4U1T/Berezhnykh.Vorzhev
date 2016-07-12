using System;

namespace CALCULATOR
{
    public class Sqrt: IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Sqrt(First); 
        }
    }
}