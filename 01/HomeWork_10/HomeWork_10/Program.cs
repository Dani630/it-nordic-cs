using System;

namespace CSharp_Shell
{

    public static class Program
    {
        public static void Main()
        {
            users[] arr = new users[3];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = new users();
                Console.Write($"Enter name {i + 1} : ");
                arr[i].name = Console.ReadLine();
                while (true)
                {
                    Console.Write($"Enter age {i + 1} : ");
                    try
                    {
                        arr[i].age = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Введите числовое выражение .");
                    }
                }
            }
            foreach (users i in arr)
            {
                Console.WriteLine($"Name : {i.name} , age in 4 years : {i.age + 4}.");
            }
        }
    }

    class users
    {
        public string name;
        public int age;
    }
}
