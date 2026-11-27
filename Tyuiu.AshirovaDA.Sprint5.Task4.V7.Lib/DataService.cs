using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AshirovaDA.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            // 1. Читаем весь текст из файла
            string data = File.ReadAllText(path);

            // 2. Преобразуем строку в число. 
            // Используем InvariantCulture на случай, если в файле точка, а не запятая
            double x = double.Parse(data.Replace(',', '.'), CultureInfo.InvariantCulture);

            // 3. Вычисляем формулу: y = 1/cos(x) + x^3
            double cosX = Math.Cos(x);

            // Проверка на деление на ноль (если cos(x) == 0)
            if (cosX == 0)
            {
                // Если косинус равен нулю, 1/cos(x) стремится к бесконечности.
                // В рамках учебных задач часто возвращают 0 или выбрасывают ошибку. 
                // Обычно в таких тестах x подбирается так, чтобы деления на ноль не было.
                // Но на всякий случай обработаем: 
                return 0;
            }

            double result = (1 / cosX) + Math.Pow(x, 3);

            // 4. Округляем до 3 знаков после запятой
            result = Math.Round(result, 3);

            return result;
        }
    }
}