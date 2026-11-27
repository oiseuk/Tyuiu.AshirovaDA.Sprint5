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

            // 2. Разбиваем строку на отдельные числа по пробелам
            // Используем StringSplitOptions.RemoveEmptyEntries, чтобы избежать ошибок при двойных пробелах
            string[] parts = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // 3. Проверяем, что файл не пустой
            if (parts.Length == 0)
            {
                return 0;
            }

            // 4. Ищем минимальное значение
            // Берем первый элемент как стартовый минимум
            double min = double.Parse(parts[0], CultureInfo.InvariantCulture);

            for (int i = 1; i < parts.Length; i++)
            {
                // Парсим каждое следующее число
                double current = double.Parse(parts[i], CultureInfo.InvariantCulture);
                if (current < min)
                {
                    min = current;
                }
            }

            // 5. Округляем результат до 3 знаков после запятой
            return Math.Round(min, 3);
        }
    }
}