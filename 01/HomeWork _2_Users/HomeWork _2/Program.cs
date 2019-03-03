using System;

namespace HomeWork__2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];
            int[] age = new int[5];
            for (int i = 0; i < name.Length; i++)
            {
                Green($"\nПользователь {i+1}.");
                Yellow("\nВведите имя пользователя : ");
                name[i] = Console.ReadLine();
                Yellow($"Введите возвраст пользователя : ");
                age[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Yellow("===============");
            for (int i = 0; i < name.Length; i++)
            {
                Yellow("===============");
                White($"\nПользователь {i + 1}.\nИмя : {name[i]}\nВозвраст : {age[i]}");
                Yellow("===============");
            }
            Yellow("===============");
        }
        static void Yellow (string i)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(i);
            Console.ResetColor();
        }
        static void Green (string i)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(i);
            Console.ResetColor();
        }
        static void White (string i)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(i);
            Console.ResetColor();
        }
    }
}
