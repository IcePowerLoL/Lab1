using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== ГЛАВНОЕ МЕНЮ ===");
                Console.WriteLine("Введите номер задания (1-16) или 0 для выхода:");
                Console.Write("Ваш выбор: ");

                if (!int.TryParse(Console.ReadLine(), out int i))
                {
                    continue;
                }

                if (i == 0)
                {
                    break;
                }

                switch (i)
                {
                    case 1: Task1.Run(); break;
                    case 2: Task2.Run(); break;
                    case 3: Task3.Run(); break;
                    case 4: Task4.Run(); break;
                    case 5: Task5.Run(); break;
                    case 6: Task6.Run(); break;
                    case 7: Task7.Run(); break;
                    case 8: Task8.Run(); break;
                    case 9: Task9.Run(); break;
                    case 10: Task10.Run(); break;
                    case 11: Task11.Run(); break;
                    case 12: Task12.Run(); break;
                    case 13: Task13.Run(); break;
                    case 14: Task14.Run(); break;
                    case 15: Task15.Run(); break;
                    case 16: Task16.Run(); break;
                    default:
                        Console.WriteLine("Задания с таким номером нет!");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню...");
                Console.ReadKey();
            }
        }
    }

    public static class Task1
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 1 Задание ===");
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static class Task2
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 2 Задание ===");
            Console.Write("Введите m:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(8);
                }
                Console.WriteLine();
            }
        }
    }

    public static class Task3
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 3 Задание ===");

            for (int i = 1; i < 11; i++)
            {
                string st = new string('8', i);
                Console.WriteLine(st);
            }
        }
    }

    public static class Task4
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 4 Задание ===");

            Console.Write("Введите 1 число:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите 2 число:");
            int y = int.Parse(Console.ReadLine());
            int min = Min(x, y);
            Console.WriteLine($"Минимумом из {x} и {y} является {min}");
        }

        public static int Min(int x, int y)
        {
            return (x > y) ? y : x;
        }
    }

    public static class Task5
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 5 Задание ===");
            Console.Write("Введите первое имя - ");
            string name1 = Console.ReadLine();
            Console.Write("Введите второе имя - ");
            string name2 = Console.ReadLine();

            if (name1 == name2)
            {
                Console.Write("Имена идентичны");
            }
            else if (name1.Length == name2.Length)
            {
                Console.Write("Длины имен равны");
            }
            else
            {
                Console.Write("Ничо не сошлось");
            }
        }
    }

    public static class Task6
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 6 Задание ===");

            Console.WriteLine("Введите 4 числа (Каждое число через Enter)");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int min = Min(x, y, z, k);
            Console.Write($"Минимальное из 4 чисел => {min}");
        }

        public static int Min(int x, int y, int z, int k)
        {
            return (Min(x, y) > Min(z, k) ? Min(z, k) : Min(x, y));
        }

        public static int Min(int x, int y)
        {
            return (x > y) ? y : x;
        }
    }

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

            if (x * y == 0)
            {
                Console.WriteLine("Нельзя нулевые координаты!!!");
                return;
            }
            if (x > 0 && y > 0)
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

    public static class Task8
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 8 Задание ===");

            int ssize = 10;
            int[] mas = new int[ssize];

            for (int i = 0; i < ssize; i++)
            {
                mas[i] = i * 2 + 2;
            }
            for (int i = 0; i < ssize; i++)
            {
                Console.Write(mas[i]);
                Console.Write(' ');
            }
            Console.WriteLine("");
            for (int i = 0; i < ssize; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }
    }

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
            for (int i = ssize - 1; i >= 0; i--)
            {
                Console.Write(mas[i]);
                Console.Write(' ');
            }
        }
    }

    public static class Task10
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 10 Задание ===");

            int ssize = 15;
            int[] mas = new int[ssize];

            for (int i = 0; i < ssize; i++)
            {
                Random rand = new Random();
                mas[i] = rand.Next(10);
            }
            for (int i = 0; i < ssize; i++)
            {
                Console.Write(mas[i]);
                Console.Write(" ");
            }
            int chet = 0;
            for (int i = 0; i < ssize; i++)
            {
                if (mas[i] % 2 == 0) chet++;
            }
            Console.WriteLine("");
            Console.Write($"Чётных элементов: {chet}");
        }
    }

    public static class Task11
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== 11 Задание ===");

            int rows = 8;
            int cols = 5;
            int[,] mas = new int[rows, cols];

            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mas[i, j] = rand.Next(10, 100);
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
        }
    }

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
            int MaxIndex = 0;
            for (int i = 0; i < mas2.Length; i++)
            {
                if (mas2[i] > mas2[MaxIndex])
                {
                    MaxIndex = i;
                }
            }
            Console.Write($"Индекс строки с наибольшим по модулю произведением: {MaxIndex}");
        }
    }

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
            for (int i = 0; i < ssize; i++)
            {
                mas[i] = rdm(a, b);
            }

            for (int i = 0; i < ssize; i++) Console.Write($"{mas[i]} ");
        }

        public static int rdm(int a, int b)
        {
            Random rand = new Random();
            return rand.Next(a, b + 1);
        }
    }

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

        static void vivod(int[] mas, int ssize)
        {
            for (int i = 0; i < ssize; i++)
            {
                Console.Write($"{mas[i]} ");
            }
            Console.WriteLine();
        }
    }

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
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{mas1[i]} ");
            }
        }

        static void sort(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = 0; j < mas.Length - i - 1; j++)
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