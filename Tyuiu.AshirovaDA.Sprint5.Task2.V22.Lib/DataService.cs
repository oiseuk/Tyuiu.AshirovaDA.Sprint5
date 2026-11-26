using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AshirovaDA.Sprint5.Task2.V22.Lib
{
    public class DataService : ISprint5Task2V22
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            // 1. Формируем путь во временной папке
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask2.csv";
            string path = Path.Combine(tempPath, fileName);

            StringBuilder sb = new StringBuilder();

            // 2. Проходим по массиву, заменяем значения и формируем строку
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Логика замены
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                    // Если элемент 0, он так и остается 0 (он не положительный и не отрицательный)

                    sb.Append(matrix[i, j]);

                    // Разделитель столбцов (ставим точку с запятой для русской локали)
                    if (j < cols - 1)
                    {
                        sb.Append(";");
                    }
                }
                // Перенос строки после каждой строки матрицы
                sb.AppendLine();
            }

            // 3. Записываем в файл (перезаписываем)
            File.WriteAllText(path, sb.ToString());

            return path;
        }
    }
}