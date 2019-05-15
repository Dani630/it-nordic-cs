using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_13
{
     class Helicopter : Flying
	{
		public byte BladesCount { get; private set; }

		public Helicopter(int maxHeigth, byte bladesCount) : base (maxHeigth)
		{ 
			BladesCount = bladesCount;
			Console.WriteLine("It s a helicopter , welcome aboard !");
		}

		public void WriteAllProperties()
		{
			Console.WriteLine($"BlasdesCount : {BladesCount}\n" +
				$"CurrentHeigth : {CurrentHeigth}\n" +
	            $"MaxHeigth : {MaxHeight}");
		}

		
		public override void WriteAllProprties()
		{
			throw new NotImplementedException();
		}
		
	}
}
