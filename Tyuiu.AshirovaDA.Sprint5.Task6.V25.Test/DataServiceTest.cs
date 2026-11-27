using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task6.V25.Lib;

namespace Tyuiu.AshirovaDA.Sprint5.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем временный файл для проверки
            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, "Это! Не просто! Строка! С восклицательными знаками!!!");

            // Вызываем метод
            int result = ds.LoadFromDataFile(tempPath);

            // В тексте 5 восклицательных знаков (3 отдельных + 3 в конце = 6? Давайте посчитаем)
            // "Это!" (1), "просто!" (2), "Строка!" (3), "знаками!!!" (4, 5, 6)
            // Итого: 1 + 1 + 1 + 3 = 6 знаков.
            double expected = 6;

            Assert.AreEqual(expected, result);

            // Удаляем временный файл
            File.Delete(tempPath);
        }
    }
}