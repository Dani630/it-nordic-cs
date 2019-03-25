using System;
using System.Collections.Generic;

namespace ClassWork_10
{
	class Program
	{
		static void Main(string[] args)
		{
			string y = Console.ReadLine();
			List<bool> i = Convert_txt(y);
			foreach (bool o in i)
				Console.Write(o);









			/*
			Pet p1 = new Pet();
			p1.Name = "Andrei";
			p1.Kind = "Dog";
			p1.Sex = 'M';
			p1.Age = 36;
			Pet p2 = new Pet
			{
			Name = "Ilya ",
			Kind = "Cat",
			Sex = 'M',
			Age = 18
		};
			Console.WriteLine($"{p1.Name} is a {p1.Kind} ({p1.Sex})  of  {p1.Age} years old");
			Console.WriteLine($"{p2.Name} is a {p2.Kind} ({p2.Sex})  of   {p2.Age} years old");
			*/
		}

















		public static List<bool> Convert_txt(string value)
		{
			List<bool> resuult = new List<bool>();
				double result = 0;
				List<string> check_words = new List<string>()
		{
			"123456"
		};
				string[] text_words = value.Split(" ");
			try
			{
				for (int words = 0; words < text_words.Length; words++)
				{
					char[] words_ABC = text_words[words].ToLower().ToCharArray();
					for (int check = 0; check < check_words.Count; check++)
					{
						char[] check_ABc = check_words[check].ToLower().ToCharArray();
						for (int i = 0; i < words_ABC.Length; i++)
						{
							if (words_ABC[i] == check_ABc[i])
								result++;
							if (result >= 5)
							{
								resuult.Add(true);
								break;
							}
						}
					}
				}
			}
			catch { }
			foreach (bool p in resuult)
				Console.Write(p);
			return
				resuult;
		}
	}
}
