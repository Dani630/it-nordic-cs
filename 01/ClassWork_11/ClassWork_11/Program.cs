using System;

namespace ClassWork_11
{
	class Program
	{
		static void Main(string[] args)
		{
			Pet p1 = new Pet();
			p1.Name = "Andrei";
			p1.Kind = "Dog";
			p1.Sex = 'M';
		//	p1.DateOfBirth = DateTimeOffset.Parse("2013-03-03");
			//	p1.Age = 36;
			Pet p2 = new Pet
			{
				Name = "Ilya ",
				Kind = "Cat",
				Sex = 'M',
				//	Age = 18
			};
			p1.WhiteDescription(true);
			p2.WhiteDescription(false);

		}
	}
}
