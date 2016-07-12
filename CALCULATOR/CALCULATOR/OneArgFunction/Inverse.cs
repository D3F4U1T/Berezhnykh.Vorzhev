using System;

namespace CALCULATOR
{
    public class Inverse : IOneCalculator
    {
        public double Calculate(double First)
        {
            return -First;
        }
    }
}