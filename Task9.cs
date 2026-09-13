using System;

namespace Lab1
{
    public static class Task9
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 9 Задание ===");

            int ssize = 50;
            int[] mas = new int[ssize];

            for (int i = 0; i < ssize; i++)
            {
                mas[i] = i * 2 + 1;
            }
            Console.WriteLine("По порядку");
            for (int i = 0; i < ssize; ++i)
            {
                Console.Write(mas[i]);
                Console.Write(' ');
            }
            Console.WriteLine("");
            Console.WriteLine("В обратном порядке");
            for(int i = ssize - 1; i >= 0; i--)
            {
                Console.Write(mas[i]);
                Console.Write(' ');
            }
        }
    }
}