using System;

namespace Home_Work_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num_1 = 0;
            double num_2 = 0;
            double result = 0;
            double result_2 = 0;
            string vvod = null;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите тип фигуры :\n\n" +
                "1.Круг\n\n" +
                "2.Равносторонний треугольник\n\n" +
                "3.Прямоугольник\n");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                vvod = Console.ReadLine();
                if (vvod == "1" ||
                    vvod == "2" ||
                    vvod == "3")
                    break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nОшибка");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Ввод : ");
                    Console.ResetColor();
                }
            }
            switch (vvod)
            {
                case "1":
                    Console.Write("\nРадиус : ");
                    while (true)
                    {
                        {
                            try
                            {
                                num_1 = Convert.ToDouble(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nОшибка");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Радиус : ");
                                Console.ResetColor();
                            }
                        }
                    }
                    result = num_1 * (2 * Math.PI);
                    result_2 = Math.PI * (num_1 * num_1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n\nПлощадь : {result} \n\nПеримитр : {result_2}\n\n");
                    break;
                case "2":
                    Console.Write("\nВведите длину стороны : ");
                    while (true)
                    {
                        try
                        {
                            num_1 = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nОшибка");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Сторона : ");
                            Console.ResetColor();
                        }
                    }
                    break;
                case "3":
                    Console.Write("\nВведите ширину : ");
                    while (true)
                    {
                        try
                        {
                            num_1 = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nОшибка");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Ширина : ");
                            Console.ResetColor();
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nВведите высоту : ");
                    while (true)
                    {
                        try
                        {
                            num_2 = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nОшибка");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Высоту : ");
                            Console.ResetColor();
                        }
                    }
                    Console.WriteLine("\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    result = 2 * (num_1 + num_2);
                    Console.WriteLine($"Периметр : {result}\n\n");
                    break;
                    
            }
                
        }
    }
}
