using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task1.V22.Lib;

namespace Tyuiu.AshirovaDA.Sprint5.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            // Вызываем метод с теми же значениями, что и в задании
            string path = ds.SaveToFileTextData(-5, 5);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            // Проверяем, что файл действительно создался
            Assert.AreEqual(true, fileExists);
        }
    }
}