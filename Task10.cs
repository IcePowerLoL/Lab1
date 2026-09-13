using System;

namespace Lab1
{
    public static class Task10
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 10 Задание ===");

            int ssize = 15;
            int[] mas = new int[ssize];

            for(int i = 0; i < ssize; i++)
            {
                Random rand = new Random();
                mas[i] = rand.Next(10);
            }
            for(int i = 0; i < ssize; i++)
            {
                Console.Write(mas[i]);
                Console.Write(" ");
            }
            int chet = 0;
            for(int i = 0; i < ssize; i++)
            {
                if (mas[i] % 2 == 0) chet++;
            }
            Console.WriteLine("");
            Console.Write($"Чётных элементов: {chet}");
        }
    }
}