using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task7.V12.Lib;

namespace Tyuiu.AshirovaDA.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Home\Desktop\Уник ТИУ\Tyuiu.AshirovaDA.Sprint5\Tyuiu.AshirovaDA.Sprint5.Task7.V12\bin\Debug\net8.0\InPutDataFileTask7V12.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}