using System;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task2.V22.Lib;

namespace Tyuiu.AshirovaDA.Sprint5.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите 9 целых чисел для массива 3x3 (каждое с новой строки):");

            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызов метода
            string path = ds.SaveToFileTextData(matrix);

            // Читаем файл, чтобы показать, что в нем записано
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"\nФайл сохранен по пути: {path}");
            Console.ReadLine();
        }
    }
}