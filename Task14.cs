using System;

namespace Lab1
{
    public static class Task14
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 14 Задание ===");

            Random rand = new Random();

            int ssize = 10;
            int[] mas1 = new int[ssize];
            int[] mas2 = new int[ssize];
            int[] mas3 = new int[ssize];
            int[] mas4 = new int[ssize];
            int[] mas5 = new int[ssize];

            for (int i = 0; i < ssize; i++)
            {
                mas1[i] = Task13.rdm(0, 100);
            }
            for (int i = 0; i < ssize; i++)
            {
                mas2[i] = Task13.rdm(0, 100);
            }
            for (int i = 0; i < ssize; i++)
            {
                mas3[i] = Task13.rdm(0, 100);
            }
            for (int i = 0; i < ssize; i++)
            {
                mas4[i] = Task13.rdm(0, 100);
            }
            for (int i = 0; i < ssize; i++)
            {
                mas5[i] = Task13.rdm(0, 100);
            }

            vivod(mas1, ssize);
            vivod(mas2, ssize);
            vivod(mas3, ssize);
            vivod(mas4, ssize);
            vivod(mas5, ssize);

        }
        static void vivod(int[] mas,int ssize)
        {
            for (int i = 0; i < ssize; i++)
            {
                Console.Write($"{mas[i]} ");
            }
            Console.WriteLine();
        }
    }
}