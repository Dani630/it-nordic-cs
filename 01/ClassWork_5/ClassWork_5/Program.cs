using System;
using System.Collections.Generic;

namespace ClassWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             List<string> nums = new List<string>
             {
                 "Black",
                 "Blue",
                 "Cyan",
                 "Grey",
                 "Green"
             };
             string[] nams_2 = new string[4];
             Console.WriteLine("Введите 4 цвета в палитру .");
             int qwer = 3;
             string num_1 = "О";
             //bool qw = true;
             for (int i = 0; i < 4; i++)
             {
                 Console.Write("Ввод : ");
                 num_1 = Console.ReadLine();
                 /*while (qw == true)
                {

                     for (int p = 0; p < nums.Count; p++)
                     {
                         if (num_1 != nums[p])
                         {
                             qwer = qwer + 1;
                             Console.WriteLine("Ошибка");
                         }
                         else if (num_1 == nums[p])
                         {
                             qw = false;
                         }
                     }
                 }
                 for (int o = 0; o < 5; o++)
                 {

                     if (num_1 == nums[o])
                     {
                         nams_2[i] = Convert.ToString(num_1);
                         nums.RemoveAt(i);
                     }
                     else if (num_1 != nums[o])
                     {
                        qwer = qwer + 1;
                     }
                 }
             }
             Console.WriteLine("Набор цветов : \n");
             foreach (string numss in nums)
               {
                  Console.WriteLine(numss);
               }
             foreach (string numsss in nams_2)
             {
                 Console.WriteLine(numsss);
             }


             List<string> nums = new List<string>
             {
                 "1",
                 "2",
                 "3",
                 "4",
                 "5",
                 "6"
             };
             */











            /*
 
                        








            Console.Write("Введите число : ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i < 0)
                Console.WriteLine($"Число {i} отрицательное");
            else if (i > 0)
                Console.WriteLine($"Число {i} неотрицательное");




            Console.Write("Введите число : ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число " + (i > 0) ? "Число положительное" : "Число отрицательное");
            








    */





            
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
