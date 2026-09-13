using System;

namespace Lab1
{
    public static class Task11
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 11 Задание ===");

            int rows = 8;
            int cols = 5;
            int[,] mas = new int[rows, cols];

            Random rand = new Random();
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    mas[i, j] = rand.Next(10, 100);
                }
            }

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write(mas[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}