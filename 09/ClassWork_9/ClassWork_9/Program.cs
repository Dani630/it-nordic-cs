using System;
using System.Diagnostics;

namespace ClassWork_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    _____\n    |   |\n    |   |\n    |   |\n    |   |\n =-=-----=-=\n  =-=---=-=\n   =-=-=-=\n    =-=-=\n     =-=\n      =\n\n");
            Console.ResetColor();

            Stopwatch stopwathc = new Stopwatch();

            int len = 0;

            for (int i = 1_000; i < 20000; i = i + 500)
            {
                len++;
                int[] initialArray = GetTestArray(i, 1_000_000);

                int[] bubbleSortedArray = (int[])initialArray.Clone();

                stopwathc.Start();
                BubbleSort(initialArray);
                stopwathc.Stop();
                Console.WriteLine("Bubbe sort done in {0} {1}", stopwathc.ElapsedMilliseconds , len);

                int[] dotneSortedArray = (int[])initialArray.Clone();

                stopwathc.Start();
                BubbleSort(dotneSortedArray);
                stopwathc.Stop();
                Console.WriteLine("Donte sort done in {0} ", stopwathc.ElapsedMilliseconds);

            }
        }
        private static int[] GetTestArray(int Length , int maxValue)
        {
         //   const int Length = 5;
          //  const int maxValue = 100;
            var arr = new int[Length];

            var rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(maxValue);
            }
            return arr;
        }
        private static void WriteArrayState(string massage, int[] arr)
        {
            Console.WriteLine(massage);
            for (var i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        private static void BubbleSort(int[] arr)
        {
            for (int o = 0; o < arr.Length; o++)
            {
                var limit = arr.Length - 1;

                for (int i = 0; i < limit; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
        }
    }
}




























//   _____
//   |   |
//   |   |
//   |   |
//   |   |
//=-=-----=-=
// =-=---=-=
//  =-=-=-=
//   =-=-=
//    =-=
//     =

