using System;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task3.V21.Lib;

namespace Tyuiu.AshirovaDA.Sprint5.Task3.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3; // Значение из задания

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* X = {x}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(x);

            // Читаем бинарный файл для вывода на экран
            double resultFromFile;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                resultFromFile = reader.ReadDouble();
            }

            Console.WriteLine($"Значение функции: {resultFromFile}");
            Console.WriteLine($"Файл сохранен по пути: {path}");
            Console.ReadLine();
        }
    }
}