using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AshirovaDA.Sprint5.Task3.V21.Lib
{
    public class DataService : ISprint5Task3V21
    {
        public string SaveToFileTextData(int x)
        {
            // 1. Путь через временную папку
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask3.bin";
            string path = Path.Combine(tempPath, fileName);

            // 2. Вычисление формулы: y(x) = (x^2 + 1) / sqrt(4x^2 - 3)
            double numerator = Math.Pow(x, 2) + 1;
            double denominator = Math.Sqrt(4 * Math.Pow(x, 2) - 3);
            double result = numerator / denominator;

            // 3. Округление до 3 знаков после запятой
            result = Math.Round(result, 3);

            // 4. Запись в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(result);
            }

            // 5. Возврат пути
            return path;
        }
    }
}