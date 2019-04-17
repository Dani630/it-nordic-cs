using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_17_2 
{

	public delegate void RandomGaneratedHadler(int bytesDone, /*IndexOutOfRangeException*/int totalBytes);

	//public delegate void EventHandler();

	//public delegate void EventHandler();

	class RandomDataGenerator
	{

		public event EventHandler <RandomEventArgs> RandomGeneration;

		public event EventHandler RandomDataGenerationDone;

		public byte[] GetRandomData(int dataSize, int bytesDoneToRaiseEvent)
		{
			Random rand = new Random();
			byte[] itog = new byte[dataSize];
			for (int i = 0; i < dataSize; i++)
			{
				itog[i] = (byte)rand.Next(256);
				if ((i + 1) % bytesDoneToRaiseEvent == 0)
				{
					RandomGeneration(i + 1, dataSize);
				}
			}
			_RandomDataGenerationDone(2 , 2);
			return itog;
		}


		protected virtual void _RandomDataGenerationDone(int ByteDone , int totalBytes)
		{
			var del = RandomGeneration as EventHandler;
			if (del != null)
				del.Invoke(ByteDone, totalBytes);
		}

		protected virtual void OnRandomGeneration(object bytesDone ,  RandomEventArgs totalBytes)
		{
			RandomDataGenerationDone?.Invoke(bytesDone, totalBytes);
		}
	}
}
