using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task4.V7.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace Tyuiu.AshirovaDA.Sprint5.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            // 1. Ваш путь к файлу (не забудьте проверить, что он совпадает с вашим)
            string path = @"C:\Users\Home\Desktop\Уник ТИУ\Tyuiu.AshirovaDA.Sprint5\Tyuiu.AshirovaDA.Sprint5.Task4.V7\bin\Debug\net8.0\InPutDataFileTask4V7.txt";

            // 2. Проверка, что файл существует
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            // 3. Проверка правильности вычислений
            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            // Вставляем РЕАЛЬНОЕ значение, которое вернула программа
            double expected = 2.876;

            // Сравниваем с точностью до 0.001
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}