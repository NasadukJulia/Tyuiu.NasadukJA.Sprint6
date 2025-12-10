using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NasadukJA.Sprint6.Task1.V21.Lib
{
    public class DataService : ISprint6Task1V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 - 2 * x;  
                double y;

                if (denominator == 0)
                {
                    y = 0; 
                }
                else
                {
                    y = Math.Cos(x) + (Math.Sin(x) / denominator) - 4 * x;
                    y = Math.Round(y, 2);
                }

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
