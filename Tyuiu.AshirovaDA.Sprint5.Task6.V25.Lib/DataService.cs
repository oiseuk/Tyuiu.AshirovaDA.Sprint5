using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AshirovaDA.Sprint5.Task6.V25.Lib
{
    public class DataService : ISprint5Task6V25
    {
        public int LoadFromDataFile(string path)
        {
            // 1. Читаем весь текст из файла
            string content = File.ReadAllText(path);

            // 2. Считаем количество символов '!'
            int count = 0;
            foreach (char c in content)
            {
                if (c == '!')
                {
                    count++;
                }
            }

            return count;
        }
    }
}