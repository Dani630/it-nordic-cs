using System;

namespace HomeWork_3
{
    enum volume
    {
        container = 0x1,
        container_2 = 0x2,
        container_3 = 0x4
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num_1 = 0;
            int num_2 = 0;
            int num_3 = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Какой обьем сока (в литрах) требуется упаковать ?\n");
            Console.ForegroundColor = ConsoleColor.White;
            double number = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            while (true)
            {
                while (true)
                {
                    if (number < 20)
                    {
                        break;
                    }
                    number = number - 20;
                    num_1 = num_1 + 1;
                }
                while (true)
                {
                    if (number < 5)
                    {
                        break;
                    }
                    number = number - 5;
                    num_2 = num_2 + 1;
                }
                while (true)
                {
                    if (number < 0)
                    {
                        if (number < 0 && number > -1)
                        {
                            num_3 = num_3 + 1;
                        }
                        num_3 = num_3 - 1;
                        break;
                    }
                    number = number - 1;
                    num_3 = num_3 + 1;
                }
                if (number < 0)
                {                 
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\nВам потребуются следующие контейнеры : ");
            Console.ForegroundColor = ConsoleColor.Green;
            if (num_1 > 0)
            {
                Console.Write($"\n 20 л : {num_1} шт.\n");
            }
            if (num_2 > 0)
            {
                Console.Write($"\n 5 л : {num_2} шт.\n");
            }
            if (num_3 > 0)
            {
                Console.Write($"\n 1 л : {num_3} шт.\n");
            }
            Console.WriteLine("\n\n\n\n");
            Console.ResetColor();
            /*
            Console.WriteLine(
            "0x{0}\t({1})\t{2}",
             value.ToString("X").PadLeft(2, '0'),
             Convert.ToString(value, 2).PadLeft(8, '0'),
             value.ToString().PadLeft(3, '0'));
             */
        }
    }
}
