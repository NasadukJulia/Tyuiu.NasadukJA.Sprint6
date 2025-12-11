using System.IO;

using Tyuiu.NasadukJA.Sprint6.Task6.V10.Lib;

namespace Tyuiu.NasadukJA.Sprint6.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFileExists()
        {
            string path = @"C:\Users\Julia\Desktop\DataSprint6\InPutFileTask6V10.txt";
            bool exists = File.Exists(path);
            Assert.IsTrue(exists);
        }
    }
}
