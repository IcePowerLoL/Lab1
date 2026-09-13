using System;

namespace Lab1
{
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

            if(name1 == name2)
            {
                Console.Write("Имена идентичны");
                
            }
            else if(name1.Length == name2.Length)
            {
                Console.Write("Длины имен равны");
            }
            else
            {
                Console.Write("Ничо не сошлось");
            }
        }
        
    }
}
