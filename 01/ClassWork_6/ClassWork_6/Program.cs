using System;

namespace ClassWork_6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            do
            {
                string num = Console.ReadLine();
                if (num == "Exit")
                    break;
                if (num.Length > 15)
                    Console.WriteLine("Too long string. Try another");
                else if (num.Length <= 15)
                    Console.WriteLine($"Entered string length is {num.Length}");
            }
            while (true);
            

            // do { if (Console.ReadLine() == "Exit") break; } while (true);



            do
            {
                string num = Console.ReadLine();
                if (num == "Exit")
                    break;
                Console.WriteLine(num.Length > 15 ? "Too long string. Try another" : $"Entered string length is {num.Length}");
            }
            while (true);
            



            double[] numbers = new double[5];
            double result = 0;
            while (true)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Введите число {i + 1} : ");
                    try
                    {
                        numbers[i] = Convert.ToDouble(Console.ReadLine());
                        result += numbers[i];
                    }
                    catch
                    {
                        Console.WriteLine("\n\n    Ошибка\n(Введите число .)\n");
                        i--;
                    }
                    
                }
                break;
            }
            Console.WriteLine($"\n\nРезультат : {result}\n\n\n");
            */
            double result_max = 0;
            int Days = 0;
            int l = 0;
            var marks = new[]
            {
                new [] { 2, 3, 3, 2, 3},
                new [] { 2, 4, 5, 3 },
                null,
                new [] { 5, 5, 5, 5 },
                new [] {4}
            };
            double result = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] != null)
                {                   
                    try
                    {
                        for (int o = 0; o < marks[i][o]; o++)
                        {
                            l++;
                            result += marks[i][o];
                        }
                    }
                    catch
                    {

                    }
                    Days++;
                    Console.WriteLine($"Day {Days} : {result / l}");
                    result_max += result;
                    result = 0;
                    l = 0;
                }
                else
                {
                    Days++;
                }
            }
            result_max = result / marks.Length;
            Console.WriteLine(result_max);

            
        }
    }
}
