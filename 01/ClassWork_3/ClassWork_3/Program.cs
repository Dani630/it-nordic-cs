using System;
using System.Collections.Generic;
namespace ClassWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Введите первое число ");
            double num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите арифм. оператор");
            char operato = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            double num_2 = Convert.ToInt32(Console.ReadLine());
            double itog = 0;
            if (operato == '+')
            {
                itog = num_1 + num_2;
            }
            else if (operato == '-')
            {
                itog = num_1 - num_2;
            }
            else if (operato == '*')
            {
                itog = num_1 * num_2;
            }
            else if (operato == '/')
            {
                itog = num_1 / num_2;
            }
            Console.WriteLine("Итог : {0}",itog);
            Console.ReadLine();
            */
            Console.WriteLine("Введите первое число ");
            double num_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите арифм. оператор");
            char operato = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            double num_2 = Convert.ToDouble(Console.ReadLine());
            double itog = 0;
            itog = psp.pspp(operato ,num_1, num_2);
            Console.WriteLine("Итог : {0}", itog);
            Console.ReadLine();

        }
    }
    class psp
    {
        static public double pspp(char oper , double num_1 , double num_2 , double num_3 = 0 , double num_4 = 0)
        {
            if (oper == '+')
            {
                return num_1 + num_2 + num_3 + num_4;
            }
            if (oper == '-')
            {
                return num_1 - num_2 - num_3 - num_4;
            }
            if (oper == '*')
            {
                return num_1 * num_2 * num_3 * num_4;
            }
            if (oper == '/')
            {
                return num_1 / num_2 / num_3 / num_4;
            }
            else
            {
                return 0;
            }
        }
    }
}
