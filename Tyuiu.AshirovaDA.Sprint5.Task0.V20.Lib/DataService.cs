using System.IO; // Обязательно для работы с файлами
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AshirovaDA.Sprint5.Task0.V20.Lib
{
    public class DataService : ISprint5Task0V20
    {
        public string SaveToFileTextData(int x)
        {
            // 1. Создаем путь (как в примере)
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            // 2. Вычисляем вашу формулу
            double result = 2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2;

            // 3. Округляем до 3-х знаков
            double roundedResult = Math.Round(result, 3);

            // 4. Записываем в файл. 
            // Используем InvariantCulture, чтобы точка была разделителем, а не запятая
            File.WriteAllText(path, roundedResult.ToString(CultureInfo.InvariantCulture));

            // 5. Возвращаем путь
            return path;
        }
    }
}