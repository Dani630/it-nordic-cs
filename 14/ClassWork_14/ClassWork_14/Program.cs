using System;

namespace ClassWork_14
{
	class Program
	{
		static void Main(string[] args)
		{			
			using (var errorsList = new ErrorsList("Errors"))
			{
				errorsList.Add("1");
				errorsList.Add("2");

				foreach (var write in errorsList)
				{
					Console.WriteLine($"{errorsList.Category} : {write}");
				}

				errorsList.WriteToConsole();
			}
			
		}
	}
}
