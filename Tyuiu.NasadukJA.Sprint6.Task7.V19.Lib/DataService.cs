using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NasadukJA.Sprint6.Task7.V19.Lib
{
    public class DataService : ISprint6Task7V19
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');

            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] values = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = Convert.ToInt32(values[c]);
                }
            }

            return matrix;
        }
    }
}
