using System;

namespace Lab1
{
    public static class Task6
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 6 Задание ===");

            Console.WriteLine("Введите 4 числа");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int min = Min(x, y, z, k);
            Console.Write($"Минимальное из 4 чисел => {min}");
        }
        public static int Min(int x, int y, int z, int k)
        {
            return (Min(x, y) > Min(z, k) ? Min(z,k) : Min(x,y));
        }
        public static int Min(int x, int y)
        {
            return (x > y) ? y : x;
        }
    }
}
