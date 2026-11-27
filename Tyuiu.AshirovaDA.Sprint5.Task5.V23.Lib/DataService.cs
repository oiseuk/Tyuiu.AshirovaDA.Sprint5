using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AshirovaDA.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            // 1. Читаем файл
            string text = File.ReadAllText(path);

            // 2. Разбиваем на массив строк
            string[] parts = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Инициализируем минимум очень большим числом, чтобы первое же вещественное его перебило
            double min = double.MaxValue;
            bool foundRealNumber = false; // Флаг, нашли ли мы хоть одно дробное число

            for (int i = 0; i < parts.Length; i++)
            {
                string part = parts[i].Trim();

                // Проверяем, есть ли в числе точка (или запятая). 
                // Если нет — это целое число, по условию задания его пропускаем.
                if (part.Contains(".") || part.Contains(","))
                {
                    // Заменяем запятую на точку на случай, если файл сохранен в русской локали
                    string cleanNumber = part.Replace(',', '.');

                    double current = double.Parse(cleanNumber, CultureInfo.InvariantCulture);

                    if (current < min)
                    {
                        min = current;
                        foundRealNumber = true;
                    }
                }
            }

            // Если вдруг в файле вообще нет вещественных чисел, возвращаем 0
            if (!foundRealNumber) return 0;

            // 3. Округляем до 3 знаков
            return Math.Round(min, 3);
        }
    }
}