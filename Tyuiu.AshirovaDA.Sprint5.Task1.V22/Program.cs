using System;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task1.V22.Lib;

namespace Tyuiu.AshirovaDA.Sprint5.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            // Заданный диапазон
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Диапазон: [{startValue}; {stopValue}]");
            Console.WriteLine("* Шаг: 1                                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вывод на экран в виде таблицы
            Console.WriteLine("|   X   |  F(X)  |");
            Console.WriteLine("------------------");

            for (double x = startValue; x <= stopValue; x += 1)
            {
                double result;
                if (x == 2)
                {
                    result = 0;
                }
                else
                {
                    result = Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x;
                }

                result = Math.Round(result, 2);
                Console.WriteLine($"| {x,5} | {result,6} |");
            }

            Console.WriteLine("------------------");

            // Вызов метода для сохранения в файл
            string path = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine($"Файл сохранен по пути: {path}");

            Console.ReadLine();
        }
    }
}