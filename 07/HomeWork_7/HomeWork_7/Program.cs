using System;

namespace HomeWork_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string vvod;
            vvod = Console.ReadLine();
            char[] list = vvod.ToCharArray();
            int bracket = 0;
            int bracket_2 = 0;
            bool right = true;
            for (int i = 0; i  < list.Length; i++)
            {
                if (list[i] == '(' || list[i] == ')' )
                {
                    bracket++;
                }
                if (list[i] == '[' || list[i] == ']')
                {
                    bracket_2++;
                }
            }
            if (bracket % 2 != 0)
            {
                right = false;
            }
            if (bracket_2 % 2 != 0)
            {
                right = false;
            }
            Console.WriteLine(string.Join("" , list) + "  : {0}",right);
        }
    }
}
