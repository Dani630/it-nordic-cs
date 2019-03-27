using System;

namespace ClassWork_7
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            double num_1;
            double num_2;
            Console.Write("Введите число 1 : ");
            num_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число 2 : ");
            num_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num_1 + " * " + num_2 + " = " + (num_1 * num_2).ToString("#.##"));
            Console.WriteLine(string.Format("{0} + {1} = {2 : #.##}",num_1 , num_2 , num_1 + num_2));
            Console.WriteLine($"{num_1} - {num_2} = {(num_1 - num_2).ToString("#.##")}");
            */

            //contains  (проверка строки)
            //StartsWith  (проверка начала)
            //EndsWith   (проверка конца)
            // indexof || LastIndexof
            // Replace
            // Substring

            /*
            string name = "Vladimir";
            name = name.Substring(5 , 3);
            Console.WriteLine(name);
            */
            /*
            string name = "Vladimir";
            name = name.Replace("Vlad", "XXXX");
            Console.WriteLine(name);
            */

            //Split    Разделения на массив символов
            //string test = "Привте";
            //string[] words = test.Split((char[].nulll , StringSplit))

            /*
            string name = "Dani";
            name = name.ToLower();
            Console.WriteLine(name);
            */
            /*
            //Trim || TrimEnd || TrimStart
            string name = "   Dani      ";
            Console.WriteLine(name);
            Console.WriteLine(name.TrimStart());
            */

            // split          разбирает 
            // join           собирает


            ////     CNRL + R    ///// 
            ///

            string name = "1234";
            if (name.Contains("23"))
            {
                Console.WriteLine("qwee");
            }
        }
    }
}
