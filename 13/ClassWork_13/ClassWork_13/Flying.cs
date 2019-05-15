using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_13
{
	abstract public class Flying //: IFlyingObject
	{ 
		public int MaxHeight { get; private set; }
		public int CurrentHeigth { get; private set; }

		public Flying (int MaxHeigth)
		{
			this.MaxHeight = MaxHeight;
		}

		public void TakeUpper(int delta)
		{
			if (delta <= 0)
				throw new Exception("ArgumentOutOfRangeException");
			else if (CurrentHeigth + delta > MaxHeight)
				MaxHeight = delta;
			else
				CurrentHeigth = CurrentHeigth + delta;
		}

		public void TaleLower(int delta)
		{
			if (delta <= 0)
				throw new Exception("ArgumentOutOfRangeExceptoin");
			else if (CurrentHeigth - delta > 0)
				CurrentHeigth = delta;
			if (CurrentHeigth - delta == 0)
				CurrentHeigth = 0;
			else if (CurrentHeigth - delta < 0)
				throw new Exception("Crash!");
		}


		public abstract void WriteAllProprties();


		public virtual void WriteAllProperties_2()
		{
			Console.WriteLine($"MaxHeigth : {MaxHeight}\nCurrentHeigth {CurrentHeigth}");
		}

	}
}
