using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_13
{
	interface IFlyingObject 
	{
		int MaxHeigth { get; set; }
		int CurrentHeigth { get; set; }

		void TakeUpper(int delta);
		void TakeLower(int delta);
	}
}
