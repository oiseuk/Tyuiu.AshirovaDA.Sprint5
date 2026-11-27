using System;
using System.IO;
using Tyuiu.AshirovaDA.Sprint5.Task7.V12.Lib;

namespace Tyuiu.AshirovaDA.Sprint5.Task7.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V12.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Находится в файле: ");
            Console.WriteLine(pathSaveFile);

            Console.ReadKey();
        }
    }
}