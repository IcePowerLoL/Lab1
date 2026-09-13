using System;

namespace Lab1
{
    public static class Task12
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 12 Задание ===");

            int rows = 7;
            int cols = 4;
            int[,] mas = new int[rows, cols];

            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mas[i, j] = rand.Next(-5, 6);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(mas[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            int[] mas2 = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int sum = 1;
                for (int j = 0; j < cols; j++)
                {
                    sum *= Math.Abs(mas[i, j]);
                }
                mas2[i] = sum;
            }
            int[] mas3 = mas2;
            for(int i = 0; i < rows - 1; i++)
            {
                if(mas2[i] > mas2[i + 1])
                {
                    mas2[i + 1] = mas2[i];
                }
            }
            for(int i = 0; i < rows; i++)
            {
                if (mas2[rows - 1] == mas3[i])
                {
                    Console.Write("Строка с наибольшим по модулю произведением: ");
                    Console.Write(i);
                    Console.WriteLine(' ');
                    return;
                }
            }
        }
    }
}