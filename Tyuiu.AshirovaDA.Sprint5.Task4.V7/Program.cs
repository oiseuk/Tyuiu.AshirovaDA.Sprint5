using System;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task4.V7.Lib; // Ваша библиотека

namespace Tyuiu.AshirovaDA.Sprint5.Task4.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Ищем файл в папке, откуда запускается программа (bin\Debug\net8.0)
            string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask4V7.txt");

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Проверяем, существует ли файл, чтобы программа не вылетела с ошибкой
            if (File.Exists(path))
            {
                double res = ds.LoadFromDataFile(path);
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Файл не найден! Положите файл InPutDataFileTask4V0.txt в папку bin\\Debug\\net8.0");
            }

            Console.ReadLine();
        }
    }
}