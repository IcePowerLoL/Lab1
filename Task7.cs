using System;

namespace Lab1
{
    public static class Task7
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 7 Задание ===");

            Console.Write("Введите X:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите Y:");
            int y = int.Parse(Console.ReadLine());

            if(x * y == 0)
            {
                Console.WriteLine("Нельзя нулевые координаты!!!");
                return;
                
            }
            if(x > 0 && y > 0)
            {
                Console.Write("1 четверть");
            }
            if (x < 0 && y > 0)
            {
                Console.Write("2 четверть");
            }
            if (x < 0 && y < 0)
            {
                Console.Write("3 четверть");
            }
            if (x > 0 && y < 0)
            {
                Console.Write("4 четверть");
            }
        }
        
    }
}
