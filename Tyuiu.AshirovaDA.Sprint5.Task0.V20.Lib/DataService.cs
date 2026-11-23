using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AshirovaDA.Sprint5.Task0.V20.Lib
{
    public class DataService : ISprint5Task0V20
    {
        public string SaveToFileTextData(int x)
        {
            // ИСПОЛЬЗУЕМ Path.GetTempPath() КАК ТРЕБУЕТСЯ В ЗАДАНИИ
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask0.txt";
            string path = Path.Combine(tempPath, fileName);

            // Вычисляем вашу формулу
            double result = 2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2;

            // Округляем до 3-х знаков и форматируем
            double roundedResult = Math.Round(result, 3);
            string formattedResult = roundedResult.ToString();

            // Записываем в файл (теперь в безопасную временную папку)
            File.WriteAllText(path, formattedResult);

            // Возвращаем путь
            return path;
        }
    }
}