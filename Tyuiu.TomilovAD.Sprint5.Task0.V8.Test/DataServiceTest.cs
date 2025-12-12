using Tyuiu.TomilovAD.Sprint5.Task0.V8.Lib;
using System.IO;

namespace Tyuiu.TomilovAD.Sprint5.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.TomilovAD.Sprint5\Tyuiu.TomilovAD.Sprint5.Task0.V8\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
