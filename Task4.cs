using System;

namespace Lab1
{
    public static class Task4
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 4 Задание ===");

            Console.Write("Введите 1 число:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите 2 число:");
            int y = int.Parse(Console.ReadLine());
            int min = Min(x, y);
            Console.WriteLine($"Минимумом из {x} и {y} является {min}");
        }
        public static int Min(int x, int y)
        {
            return (x > y) ? y : x;
        }
    }
}
