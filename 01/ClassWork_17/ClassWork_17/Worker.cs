using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_17
{
	public enum WorkType
	{
		Work,
		DoNothing
	}

	public delegate void WorkPerformEventHandler(
	int hours, WorkType workType);

	public class Worker
	{

		public event WorkPerformEventHandler WorkPerformed;

		public event EventHandler WorkCompleted;

		public void DoWork(int hours , WorkType workType)
		{
			for (int i = 0; i < hours; i++)
			{
				if (WorkPerformed != null)
				{
					WorkPerformed(i + 1, workType);
				}
				//WorkPerformed?.Invoke(i + 1, workType);

				/*
				var del = WorkPerformed as WorkPerformEventHandler;
				if (del != null)
					del.Invoke(i + 1, workType);
				*/	


				//(WorkPerformed as WorkPerformEventHandler)?.Invoke(i + 1, workType);
			}

			//WorkCompleted?.Invoke(this , EventArgs.Empty);

			OnWorkCompleted(this, EventArgs.Empty);

			// Ralse event that all work done!
		}

		protected virtual void OnWorkPerformed (int data , WorkType workType)
		{
			var del = WorkPerformed as WorkPerformEventHandler;
			if (del != null)
				del.Invoke(data, workType);
		}

		protected virtual void OnWorkCompleted (object sender , EventArgs e)
		{
			WorkCompleted?.Invoke(sender , e);
		}
	}
}
