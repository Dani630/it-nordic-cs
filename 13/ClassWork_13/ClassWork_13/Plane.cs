using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_13
{
     class Plane : Flying
	{
		public byte EnginesCount { get; private set; }

		public Plane (int maxHeigth , byte enginesCount) : base (maxHeigth)
		{
			EnginesCount = enginesCount;
			Console.WriteLine("It s a helicopter , welcome aboard !");
		}

		public override void WriteAllProprties()
		{
			Console.WriteLine($"BlasdesCount : {EnginesCount}\n" +
				$"CurrentHeigth : {CurrentHeigth}\n" +
				$"MaxHeigth : {MaxHeight}");
		}

		public override void WriteAllProperties_2()
		{
			Console.WriteLine($"BlasdesCount : {EnginesCount}\n");
			base.WriteAllProperties_2();
		}
	}
}
