using System;

namespace CALCULATOR
{
    
        public class ClassLog : ITwoCalculator
    {
        public double Calculate(double First, double Second)
        {
            return Math.Log(First, Second);
        }
    }
   
}