using System;

namespace Lab1
{
    public static class Task2
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 2 Задание ===");
            Console.Write("Введите m:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите n:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(8);
                }
                Console.WriteLine();
            }
        }
    }
}
