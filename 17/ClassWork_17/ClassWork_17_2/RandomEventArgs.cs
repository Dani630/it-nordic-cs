using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_17_2
{
	public class RandomEventArgs : EventArgs
	{
		public int bytesDone { get; set; }
		public int TotalBytes { get; set; }
	}
}
