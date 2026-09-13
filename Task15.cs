using System;

namespace Lab1
{
    public static class Task15
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 15 Задание ===");

            int ssize = 10;
            int[] mas1 = new int[ssize];

            for (int i = 0; i < ssize; i++)
            {
                mas1[i] = Task13.rdm(0, 100);
            }

            Console.WriteLine("До сортировки");
            for (int i = 0; i < ssize; i++)
            {
                Console.Write($"{mas1[i]} ");
            }
            Console.WriteLine();

            sort(mas1);
            Console.WriteLine("После сортировки");
            for (int i = 0;i < ssize; i++)
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