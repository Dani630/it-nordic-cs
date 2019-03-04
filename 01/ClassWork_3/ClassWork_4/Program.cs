using System;
using System.Collections.Generic;

namespace ClassWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            Console.WriteLine("Введите имена :");
            for (int i = 0;i < 5;i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("\nИмена :");
            foreach (string o in names)
            {
                Console.WriteLine(o);
            }

        }
    }
}
