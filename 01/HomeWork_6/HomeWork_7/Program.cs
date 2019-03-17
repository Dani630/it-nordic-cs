using System;

namespace HomeWork_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int text_Length_num = 0;
            string text = null;
            string text_Len_1 = null;
            while (true)
            {
                Console.Write("Введите текст : ");
                text = Console.ReadLine();
                text_Len_1 = text.Replace(",", "").Replace(".", "").Replace("?", "").Replace("!", "");
                string[] textArray = text_Len_1.Split(new char[] { ' ' });
                if (textArray.Length >= 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Слишком мало слов . Попробуйте еще раз ");
                }
            }
            string[] tex = text.Split(' ', ',', '!', '?');
            for (int i = 0; i < tex.Length; i++)
            {
                if (tex[i] != "")
                {
                    if (tex[i].StartsWith('а') || tex[i].StartsWith('А'))
                    {
                        text_Length_num = text_Length_num + 1;
                    }
                }
            }
            Console.WriteLine($"Количество слов начинающихся на букву 'А' : {text_Length_num}");
        }
    }
}