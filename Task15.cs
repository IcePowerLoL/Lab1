using System;

namespace Lab1
{
    public static class Task15
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 15 Задание ===");

            Console.Write("Введите массив для сортировки: ");
            string[] num = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] mas1 = new int[num.Length];
            Console.Clear();

            for (int i = 0; i < num.Length; i++)
            {
                mas1[i] = int.Parse(num[i]);
            }

            Console.WriteLine("До сортировки");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{mas1[i]} ");
            }
            Console.WriteLine();

            sort(mas1);
            Console.WriteLine("После сортировки");
            for (int i = 0;i < num.Length; i++)
            {
                Console.Write($"{mas1[i]} ");
            }

        }
        static void sort(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++) 
            {
                for(int j = 0; j < mas.Length - i - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        int temp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = temp;
                    }
                }
            }
        }
    }
}