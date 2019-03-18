using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWork_8
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            List<int> intList = new List<int> { 20, 40, 20, 90 };
            Console.WriteLine(string.Join(" , ", intList));
            intList.Add(21);
            intList.AddRange(new[] { 50, 3, 64, 65 });
            Console.WriteLine(string.Join(" , ", intList));
            intList.RemoveRange(4 , 2);
            Console.WriteLine(string.Join(" , ", intList));
            */

            /*
            var countries = new Dictionary<string , string>
            {
                {"Russia" , "Moscow" },
                {"Belarus" , "Tomsk" },
                { "Ukraina" , "Kiev" },
            };
            Random rand = new Random();
            

            while (true)
            {
                int i = rand.Next(4);
                KeyValuePair<string, string> pair = countries.ElementAt(i);

               Console.WriteLine($"Введите столицу страны {pair.Key}");
                string qwe = Console.ReadLine();
                string Values = pair.Value;
                if (qwe == Values)
                {
                    Console.WriteLine("Вы выйграли");
                }
                else
                {
                    Console.WriteLine("Вы проиграли");
                    break;
                }
            }
            */


            /*
            string o = Console.ReadLine();
            char[] l = o.ToCharArray();
            for (int i = l.Length - 1; i > -1 ; i--)
            {
            Console.Write(l[i]);
            }
            */

            /*
            Queue<double> numbers = new Queue<double>();
            while (true)
            {
                Console.WriteLine("Введите число : ");
                string vvod = Console.ReadLine();
                double number;
                try
                {
                        number = Convert.ToDouble(vvod);
                        numbers.Enqueue(Convert.ToDouble(vvod));
                }
                catch
                {
                    if (vvod == "exit")
                    {
                        while (true)
                        {
                            try
                            {
                                double num = numbers.Dequeue();
                                Console.WriteLine(num);
                            }
                            catch { }
                            if (numbers.Count <= 0)
                            {
                                break;
                            }
                            
                        }
                        break;
                    }
                    else if (vvod == "run")
                    {
                        while (true)
                        {
                            try
                            {
                                double num = numbers.Dequeue();
                                num = Math.Sqrt(num);
                                Console.WriteLine(num);
                            }
                            catch
                            {
                                break;
                            }
                            if (numbers.Count == 0)
                            {
                                break;
                            }
                            
                        }
                        break;
                    }
                }

            }
            */










            Stack<int> storage = new Stack<int>();
            while (true)
            {
                string vvod = Console.ReadLine();
                if (vvod == "wash")
                {
                    storage.Push(1);
                }
                else if (vvod == "dry")
                {
                    if (storage.Count > 0)
                    {
                        storage.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Нет тарелок");
                    }
                }
                else if (vvod == "exit")
                {
                    Console.WriteLine(storage.Count);
                }
            }
        }

    }
}
