using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_15
{
	class Account <T>
	{
		public string Name { get; private set; }

		public T Id{ get; private set; }

		public Account (string Name , T Id)
		{
			this.Id = Id;
			this.Name = Name;
		}

		public void WritePropeties()
		{
			Console.WriteLine($"Name : {Name}\tId : {Id}");
		}
	}
}
