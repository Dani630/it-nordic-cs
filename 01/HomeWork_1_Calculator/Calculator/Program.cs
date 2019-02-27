using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char out_2 = '!';
            while (out_2 != 'n')
            {
                out_2 = '!';
                double num_1 = 0, num_2 = 0, itog = 0;
                char operat = '!';
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nВведите число 1 : ");
                while (true)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        num_1 = Convert.ToDouble(Console.ReadLine());        
                            break;
                        
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nОшибка\nВвод : ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nОператор : ");
                while (true)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        operat = Convert.ToChar(Console.ReadLine());
                        if (operat == '+' || operat == '-' || operat == '*' || operat == '/' || operat == '^')
                        {
                            break;
                        }
                    }
                    catch
                    {
                    }
                    if (operat != '+' || operat != '-' || operat != '*' || operat != '/' || operat != '^')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n!!! Арифмические операторы :\n  -  +  *  /  ^");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nОшибка\nВвод : ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nВведите число 2 : ");
                while (true)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        num_2 = Convert.ToDouble(Console.ReadLine());
                            break;
                        
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nОшибка\nВвод : ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
                    Console.ResetColor();
                    if (operat == '+')
                    {
                        itog = num_1 + num_2;
                    }
                    else if (operat == '-')
                    {
                        itog = num_1 - num_2;
                    }
                    else if (operat == '/')
                    {
                        itog = num_1 / num_2;
                    }
                    else if (operat == '*')
                    {
                        itog = num_1 * num_2;
                    }
                    else if (operat == '^')
                    {
                        itog = Math.Pow(num_1 , num_2);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (operat == '+' || operat == '-' || operat == '*' || operat == '/')
                    {
                        Console.WriteLine($"\n-------------------\n{num_1} {operat} {num_2} = {itog}\n-------------------");
                    }
                    else if (operat == '^')
                    {
                        Console.WriteLine($"\n-------------------\n{num_1}{operat}{num_2} = {itog}\n-------------------");
                    }
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nПродолжить ?  y/n\nВвод : ");
                    Console.ResetColor();
                    while (true)
                    {
                        try
                        {
                            out_2 = Convert.ToChar(Console.ReadLine());
                        }
                        catch
                        {
                        }
                        if (out_2 == 'y' || out_2 == 'n')
                        {
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n--y/n--\nВвод : ");
                            Console.ResetColor();
                        }
                    }
                
            }
        }
    }
}
