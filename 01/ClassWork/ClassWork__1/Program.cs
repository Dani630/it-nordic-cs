using System;
using System.Threading;
namespace ClassWork__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя : ");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"Привет {name}");
            Console.ReadKey();
        }
    }
}
