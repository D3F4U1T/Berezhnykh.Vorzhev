using System;

namespace CALCULATOR.OneArgFunction
{
    public class Log : IOneCalculator
    {
        /// <summary>
        /// Considers Log
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Log(first, 10);
        }
    }
}