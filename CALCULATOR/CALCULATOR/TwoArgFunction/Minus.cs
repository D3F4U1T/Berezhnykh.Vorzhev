﻿namespace CALCULATOR.TwoArgFunction
{
    public class Minus : ITwoCalculator
    {
        /// <summary>
        /// Considers minus
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}