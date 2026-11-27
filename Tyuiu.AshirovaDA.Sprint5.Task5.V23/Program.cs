using System;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task5.V23.Lib;

namespace Tyuiu.AshirovaDA.Sprint5.Task5.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Путь к файлу в папке с программой
            string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask5V23.txt");
            Console.WriteLine($"* Файл: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (File.Exists(path))
            {
                // Вызов вашего метода
                double res = ds.LoadFromDataFile(path);
                Console.WriteLine($"Минимальное число: {res}");
            }
            else
            {
                Console.WriteLine("Файл не найден!");
                Console.WriteLine("Скопируйте ваш txt-файл в эту папку:");
                Console.WriteLine(Directory.GetCurrentDirectory());
            }

            Console.ReadLine();
        }
    }
}