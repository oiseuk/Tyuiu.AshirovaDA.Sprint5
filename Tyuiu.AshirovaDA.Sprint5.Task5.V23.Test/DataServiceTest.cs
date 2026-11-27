using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task5.V23.Lib;

namespace Tyuiu.AshirovaDA.Sprint5.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем временный файл для теста, чтобы не зависеть от диска С
            string tempPath = Path.GetTempFileName();

            // Записываем туда ваши данные из задания
            File.WriteAllText(tempPath, "10.82 -4 14.05 -9 6 19.21 12.49 10 -7.1 4.92 13.53 17.67 -6 -6.99 -5 10 -8 -8 15 6");

            // Вызываем метод
            double result = ds.LoadFromDataFile(tempPath);

            // Ожидаемый минимум из этих чисел — это -9
            double expected = -9;

            // Сравниваем результаты
            Assert.AreEqual(expected, result);

            // Удаляем временный файл
            File.Delete(tempPath);
        }
    }
}