using System;

namespace Lab1
{
    public static class Task16
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 16 Задание ===");
            Console.WriteLine();
            Console.WriteLine("=== n = 45 -> 14sec, n = 50 -> ~2min => (45;50) ===");
            Console.WriteLine();
            Console.Write("Введите число фиббоначи:");
            int n = int.Parse(Console.ReadLine());
            Console.Write(Fibonacci(n));
        }
        static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}