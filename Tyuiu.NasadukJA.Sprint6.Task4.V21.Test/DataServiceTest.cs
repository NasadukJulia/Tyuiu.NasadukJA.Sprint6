using System.IO;

using Tyuiu.NasadukJA.Sprint6.Task4.V21.Lib;

namespace Tyuiu.NasadukJA.Sprint6.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCreatedFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V21.txt");

            File.WriteAllText(path, "test");

            FileInfo fi = new FileInfo(path);

            Assert.IsTrue(fi.Exists);
        }
    }
}