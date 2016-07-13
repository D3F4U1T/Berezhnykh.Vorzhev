using System;

namespace CALCULATOR.OneArgFunction
{
    public class Sqrt: IOneCalculator
    {
        /// <summary>
        /// Considers Sqrt
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Sqrt(first); 
        }
    }
}