using System;
using Tyuiu.AshirovaDA.Sprint5.Task0.V20.Lib; // Подключаем вашу библиотеку

namespace Tyuiu.AshirovaDA.Sprint5.Task0.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем объект вашего класса
            DataService ds = new DataService();

            // 2. Задаем x = 2 (по условию задания)
            int x = 2;

            // 3. Выводим шапку (по шаблону Tyuiu)
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* X = {x}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // 4. Вызываем ваш метод. Он вычислит, сохранит в файл и вернет путь.
            string path = ds.SaveToFileTextData(x);

            // 5. Выводим на консоль результат (как требует задание)
            // Читаем файл, чтобы показать то, что реально записалось
            string resultFromFile = System.IO.File.ReadAllText(path);
            Console.WriteLine($"Результат: {resultFromFile}");
            Console.WriteLine($"Файл сохранен по пути: {path}");

            // 6. Чтобы консоль не закрылась сразу
            Console.ReadLine();
        }
    }
}