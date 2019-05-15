using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_15
{
	public sealed class Circle
	{
	    public double _radius;

		public Circle (double radius)
		{
			_radius = radius;
		}

		public double Calculate (Func<double , double> operation)
		{
			return operation(_radius);
		}
	}
}
