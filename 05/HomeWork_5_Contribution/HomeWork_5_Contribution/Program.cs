using System;

namespace HomeWork_5_Contribution
{
    class Program
    {
        static void Main(string[] args)
        {
            int qwe = 0;
            double contribution;
            double percent;
            double accumulation;
            Console.WriteLine("Введите сумму первоначального взноса в рублях : ");
            contribution = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ежедневный процент дохода в виде десятичной дроби (1% = 0.01) :");
            percent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите желаемую сумму накопления в рублях :");
            accumulation = Convert.ToDouble(Console.ReadLine());
            percent = percent * 0.01;
            Console.WriteLine(percent);
            do
            {
                if (contribution < accumulation)
                    contribution += percent;
                if (contribution > accumulation)
                    break;
                qwe++;
            }
            while (true);
            Console.WriteLine(qwe);
            Console.WriteLine(contribution);
        }
    }
}
