using System;

namespace Lab1
{
    public static class Task3
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 3 Задание ===");
            
            for(int i = 1; i < 11; i++)
            {
                string st = new string('8', i);
                Console.WriteLine(st);
            }
        }
    }
}

