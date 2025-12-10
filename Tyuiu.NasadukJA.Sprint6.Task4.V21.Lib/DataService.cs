using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NasadukJA.Sprint6.Task4.V21.Lib
{
    public class DataService : ISprint6Task4V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] values = new double[length];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                if (2 * x - 1 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3;
                }

                values[index] = Math.Round(y, 2);
                index++;
            }

            return values;
        }
    }
}
