using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NasadukJA.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (matrix[j, 4] > matrix[j + 1, 4])
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            int temp = matrix[j, k];
                            matrix[j, k] = matrix[j + 1, k];
                            matrix[j + 1, k] = temp;
                        }
                    }
                }
            }

            return matrix;
        }
    }
}
