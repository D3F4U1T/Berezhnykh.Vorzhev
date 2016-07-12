using System;

namespace CALCULATOR.TwoArgFunction
{
    
        public class ClassLog : ITwoCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
   
}