namespace CALCULATOR.OneArgFunction
{
    public class SqrQube : IOneCalculator
    {
        /// <summary>
        /// Considers Qube
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return first*first*first;
        }
    }
}