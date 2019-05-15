using System;

namespace HomeWork_5_Shool
{
    class Program
    {
        static void Main(string[] args)
        {
            double result_days = 0;
            double result_max = 0;
            double result_max_length = 0;
            double marks_o_length = 0;

            var marks = new[]
            {
                new[]   { 2 , 3 , 3 , 2 , 3},
                new[]   {2 , 4 , 5 , 3 },
                null,
                new[]   { 5 , 5 , 5 , 5},
                new[]   {4}
            };
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] != null)
                {
                    try
                    {
                        for (int o = 0; o < int.MaxValue; o++)
                        {
                            result_days += marks[i][o];
                            marks_o_length++;
                            result_max_length++;
                        }
                    }
                    catch { }
                    result_max += result_days;
                    Console.WriteLine($"The average mark for day #{i + 1} is {result_days / marks_o_length}");
                    result_days = 0;
                    marks_o_length = 0;
                }
                if (marks[i] == null)
                {
                    Console.WriteLine($"The averrage mark for day #{i + 1} is N/A");
                }               
            }
            Console.WriteLine($"\nThe average mark for all the week is {(result_max / result_max_length).ToString("#.#")}\n\n\n");
        }
    }
}

