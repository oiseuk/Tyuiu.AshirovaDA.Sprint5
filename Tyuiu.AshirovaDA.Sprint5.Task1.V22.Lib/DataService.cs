using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AshirovaDA.Sprint5.Task1.V22.Lib
{
    public class DataService : ISprint5Task1V22
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            // 1. Формируем путь к файлу во временной директории
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask1.txt";
            string path = Path.Combine(tempPath, fileName);

            // Очищаем файл перед записью
            File.WriteAllText(path, string.Empty);

            // 2. Табулирование (шаг = 1, как указано в задании)
            for (double x = startValue; x <= stopValue; x += 1)
            {
                double result;

                // 3. Проверка деления на ноль (знаменатель 2 - x = 0 при x = 2)
                if (x == 2)
                {
                    result = 0;
                }
                else
                {
                    // Формула: F(x) = sin(x) + (cos(x)+1)/(2-x) + 2x
                    result = Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x;
                }

                // 4. Округление до двух знаков после запятой
                result = Math.Round(result, 2);

                // 5. Запись в файл (используем точку, так как это безопаснее для серверов)
                string resultStr = result.ToString("F2", CultureInfo.InvariantCulture);
                File.AppendAllText(path, $"{x}\t{resultStr}\n");
            }

            return path;
        }
    }
}