using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task0.V20.Lib;

namespace Tyuiu.AshirovaDA.Sprint5.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            // Метод создаст файл во временной папке и вернет путь
            string path = ds.SaveToFileTextData(2);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            // Проверяем, что файл создался
            Assert.AreEqual(wait, fileExists);
        }
    }
}