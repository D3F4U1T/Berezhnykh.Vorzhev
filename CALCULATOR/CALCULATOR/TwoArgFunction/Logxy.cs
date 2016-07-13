using System;

namespace CALCULATOR.TwoArgFunction
{
    
        public class ClassLog : ITwoCalculator
    {
            /// <summary>
            /// Considers Log two args
            /// </summary>
            /// <param name="first"></param>
            /// <param name="second"></param>
            /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
   
}