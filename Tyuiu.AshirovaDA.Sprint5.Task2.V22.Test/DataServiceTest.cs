using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task2.V22.Lib;

namespace Tyuiu.AshirovaDA.Sprint5.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            // Тестовый массив из задания
            int[,] testArray = {
                { -8, -1, -9 },
                { 8, 5, 5 },
                { 9, 6, -2 }
            };

            string path = ds.SaveToFileTextData(testArray);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}