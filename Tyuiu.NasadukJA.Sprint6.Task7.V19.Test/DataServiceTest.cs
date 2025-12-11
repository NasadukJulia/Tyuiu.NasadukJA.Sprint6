using System.IO;

using Tyuiu.NasadukJA.Sprint6.Task7.V19.Lib;

namespace Tyuiu.NasadukJA.Sprint6.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFileExists()
        {
            string path = "InPutFileTask7V19.csv";
            bool exists = File.Exists(path);
            Assert.IsTrue(exists);
        }

        [TestMethod]
        public void TestOutputFileCreated()
        {
            string path = "TestOutPut.csv";

            if (File.Exists(path)) File.Delete(path);

            File.WriteAllText(path, "1;2;3");

            Assert.IsTrue(File.Exists(path));
        }
    }
}