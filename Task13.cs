using System;

namespace Lab1
{
    public static class Task13
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 13 Задание ===");


            Console.Write("Введите число a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int ssize = 20;
            int[] mas = new int[ssize];
            for(int i = 0; i < ssize; i++)
            {
                mas[i] = rdm(a, b);
            }
            
            for(int i = 0;i < ssize; i++) Console.Write($"{mas[i]} ");
        }
        public static int rdm(int a, int b)
        {
            Random rand = new Random();
            return rand.Next(a, b);
        }
    }
}