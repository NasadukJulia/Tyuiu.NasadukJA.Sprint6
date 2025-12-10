using System.IO;

using Tyuiu.NasadukJA.Sprint6.Task3.V9.Lib;

namespace Tyuiu.NasadukJA.Sprint6.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
        { -14, 25, 26, 18, -20 },
        { 28, 10, 6, -2, -10 },
        { 30, 25, -3, 11, 4 },
        { 11, 32, -5, -20, 17 },
        { 2, -18, 11, 8, 25 }
    };

            int[,] expected =
            {
        { -14, 25, 26, 18, -20 },
        { 28, 10, 6, -2, -10 },
        { 30, 25, -3, 11, 4 },
        { 11, 32, -5, -20, 17 },
        { 2, -18, 11, 8, 25 }
    };

            int[,] result = ds.Calculate(matrix);

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    Assert.AreEqual(expected[i, j], result[i, j]);
        }
    }
}
