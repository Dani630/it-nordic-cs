using System;

namespace ClassWork_11
{
	class Pet
	{
		public string Kind;
		public string Name;
		public char Sex;
		public DateTime DateOfBirth;

		public int Age 
		{
			get
			{
				TimeSpan age = DateTimeOffset.UtcNow.Subtract(DateOfBirth);
				return Convert.ToInt32(Math.Floor(age.TotalDays / 365.242));
			}
		}

		public string Description
		{
			get
			{
				return $"{Name} is a {Kind} ({Sex}) of {Age} years old.";
			}
		}

		public string ShortDicription
		{
			get
			{
				return $"Nmae : {Name} , Age : {Age}";
			}
		}

		public void WhiteDescription (bool showFullDescription)
		{
			/*
			if (showFullDescription)
				Console.WriteLine(Description);
			else
				Console.WriteLine(ShortDicription);
				*/
			Console.WriteLine(showFullDescription ? Description : ShortDicription);
		}
		
	}
}
