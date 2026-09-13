using System;

namespace Lab1
{
    public static class Task8
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 8 Задание ===");

            int ssize = 10;
            int[] mas = new int[ssize];

            for(int i = 0; i < ssize; i++)
            {
                mas[i] = i * 2 + 2;
            }
            for(int i = 0; i < ssize; i++)
            {
                Console.Write(mas[i]);
                Console.Write(' ');
            }
            Console.WriteLine("");
            for (int i = 0; i < ssize; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }    
    }
}