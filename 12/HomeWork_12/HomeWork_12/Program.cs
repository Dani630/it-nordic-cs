using System;

namespace HomeWork_12
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Passport user_2 = new Passport();
			user_2.DocName = "Ilya";
			user_2.DocNumber = "105";
			user_2.IssueDate = DateTimeOffset.Parse("2012 - 03 - 12");
			user_2.Country = "Russia";
			user_2.PersonName = "QWE";
			user_2.WriteToConsole();
			Console.WriteLine("\n\n");
			BaseDocument user_1 = new BaseDocument();
			user_1.DocName = "Vova";
			user_1.DocNumber = "92";
			user_1.IssueDate = DateTimeOffset.Parse("2019 - 09 - 23");
			user_1.WriteToConsole();
			

			BaseDocument user_1 = new BaseDocument("Vova", "92", DateTimeOffset.Parse("2019-09-23"));
			user_1.WriteToConsole();
			Passport user_2 = new Passport("3", DateTimeOffset.Parse("2012-04-23"), "Rwe", "32");
			user_2.WriteToConsole();
			*/
			var arr = new BaseDocument[4];
			arr[0] = new BaseDocument("Qwe", "21", DateTimeOffset.Parse("2019-02-10"));
			arr[3] = new Passport("54", DateTimeOffset.Parse("2019-04-12"), "32", "43");
			arr[1] = new Passport("21" , DateTimeOffset.Parse("2019-02-10") , "23" , "42");
			arr[2] = new BaseDocument("Qwe", "21", DateTimeOffset.Parse("2019-02-10"));

			foreach (var s in arr)
			{
				if (s is Passport)
				{

				}
			}

		}
	}
}
