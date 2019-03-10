using System;
using System.Collections.Generic;

namespace HomeWork_6_Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            string colors;
            List<string> color = new List<string>
                        {
                            "DarkRed",
                            "Gray",
                            "Blue",
                            "Red",
                            "Cyan",
                            "Yellow",
                            "White"
                        };
            List<string> color_vvod = new List<string> { };
            List<string> color_out = new List<string> { };
            List<string> colors_out_2 = new List<string> { };
            while (color_vvod.Count != 4)
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Ввод : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    colors = Console.ReadLine();
                    for (int i = 0; i < color.Count; i++)
                    {
                        if (colors == color[i])
                        {
                            color_vvod.Add(color[i]);
                            color[i] = null;
                        }

                    }
                    if (color_vvod.Count == 4)
                    {
                        break;
                    }
                }
            }
            while (true)
            {
                for (int i = 0; i < color.Count; i++)
                {
                    for (int o = 0; o < color_vvod.Count; o++)
                    {
                        if (color[i] != color_vvod[o])
                        {
                            color_out.Add(color[i]);
                            color[i] = null;
                        }
                    }
                }
                if (color_out.Count >= 3)
                {
                    break;
                }
            }
            while (true)
            {
                for (int i = 0; i < color_out.Count; i++)
                {
                    if (color_out[i] != null)
                    {
                        colors_out_2.Add(color_out[i]);
                    }
                }
                if (colors_out_2.Count == 3)
                {
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\n\nЦвета в палитре : \n\n");
            foreach (string cc in color_vvod)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"  {cc}  ");
            }
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Цвета вне палитры : \n\n");
            foreach (string ccc in colors_out_2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"  {ccc}  ");
            }
            Console.ResetColor();
            Console.WriteLine("\n\n");

        }
    }
}
