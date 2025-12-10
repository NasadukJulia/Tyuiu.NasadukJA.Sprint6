using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NasadukJA.Sprint6.Task2.V29.Lib
{
    public class DataService : ISprint6Task2V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] arr = new double[len];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 * x - 1;

                double y;

                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (2 * Math.Cos(x) + 2) / denominator
                        + Math.Cos(x)
                        - 5 * x
                        + 3;

                    y = Math.Round(y, 2);
                }

                arr[index] = y;
                index++;
            }

            return arr;
        }
    }
}
