using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_15
{
	class Calculator
	{
		static double Square (double num)
		{
			return Math.Pow(2 , num) * Math.PI;
		}

		static double Perimeter (double num)
		{
			return num *  (2 * Math.PI);
		}
	}
}
