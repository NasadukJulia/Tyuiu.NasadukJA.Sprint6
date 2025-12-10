using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NasadukJA.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = matrix[i, j];

            int[] column = new int[rows];
            for (int i = 0; i < rows; i++)
                column[i] = result[i, 4];

            Array.Sort(column);

            for (int i = 0; i < rows; i++)
                result[i, 4] = column[i];

            return result;
        }
    }
}
