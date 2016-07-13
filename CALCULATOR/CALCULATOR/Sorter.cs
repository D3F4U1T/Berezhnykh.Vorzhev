namespace CALCULATOR
{
    public class Sorter : ISort
    {
        public double[] Sort(double[] result)
        {
            double temp;
             for (int i = 0; i < result.Length-1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }
        }
    }


