using System;

namespace CALCULATOR.TwoArgFunction
{
    public class Division : ITwoCalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("");
            }
            return first/second;

        }
    }
}