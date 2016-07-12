using System;

namespace CALCULATOR
{
    public class ClassSqrt: IOneCalculator
    {
        public double Calculate(double First)
        {
            return Math.Sqrt(First); 
        }
    }
}