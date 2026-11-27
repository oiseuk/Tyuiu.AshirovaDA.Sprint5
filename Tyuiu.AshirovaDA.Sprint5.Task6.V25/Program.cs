using System;
using System.Diagnostics;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task6.V25.Lib;

namespace Tyuiu.AshirovaDA.Sprint5.Task6.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Путь к файлу (как указано в задании)
            string path = @"C:\Users\Home\Desktop\Уник ТИУ\Tyuiu.AshirovaDA.Sprint5\Tyuiu.AshirovaDA.Sprint5.Task6.V25\bin\Debug\net8.0\InPutDataFileTask6V25.txt";
            Console.WriteLine($"* Файл: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (File.Exists(path))
            {
                int result = ds.LoadFromDataFile(path);
                Console.WriteLine($"Количество восклицательных знаков: {result}");
            }
            else
            {
                Console.WriteLine("Файл не найден! Убедитесь, что он лежит в C:\\DataSprint5\\");
            }

            Console.ReadLine();
        }
    }
}