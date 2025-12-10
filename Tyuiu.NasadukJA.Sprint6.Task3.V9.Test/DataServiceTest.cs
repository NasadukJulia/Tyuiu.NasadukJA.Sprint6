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
            int[,] matrix =
            {
                { -14, 25, 26, 18, 17 },
                {  28, 10,  6, -2,  4 },
                {  30, 25, -3, 11, -10 },
                {  11, 32, -5, -20, 25 },
                {   2, -18, 11, 8, -20 }
            };

            DataService ds = new DataService();

            int[,] res = ds.Calculate(matrix);

            int[,] wait =
            {
                {   2, -18, 11,  8, -20 },  
                {  30,  25, -3, 11, -10 },
                {  28,  10,  6, -2,   4 },
                { -14,  25, 26, 18,  17 },
                {  11,  32, -5, -20, 25 }
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
