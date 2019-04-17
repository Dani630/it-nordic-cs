using System;

namespace ClassWork_15
{
	class Program
	{
		public delegate double DoCalculator (double number); 

		static void Main(string[] args)
		{
			Circle circle = new Circle(12);
			DoCalculator Perimeter = (double num) => num * (2 * Math.PI);
			Console.WriteLine(Perimeter(circle._radius));
			DoCalculator Square = (double num) => Math.Pow(2, num) * Math.PI;
			Console.WriteLine(Square(circle._radius));
		}
	}
}












































/*
Account<int> user_1 = new Account<int>("User_1", 10100);
Account<string> user_2 = new Account<string>("User_1", "1010");
Account<Guid> user_3 = new Account<Guid>("User_1", Guid.NewGuid());

user_1.WritePropeties();
			user_2.WritePropeties();
			user_3.WritePropeties();









	Circle circle_1 = new Circle(1.5);
			Calculator  = new Calculator();
			*/
