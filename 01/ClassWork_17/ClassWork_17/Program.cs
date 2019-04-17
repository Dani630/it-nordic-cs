using System;

namespace ClassWork_17
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			WorkPerformEventHandler del1 = WorkPerform1;
			WorkPerformEventHandler del2 = WorkPerform2;
			WorkPerformEventHandler del3 = WorkPerform3;

			del1 += del2 + del3;

			int result = del1(8, WorkType.DoNothing);

			Console.WriteLine($"Result : {result} hours");
			*/



			var worker = new Worker();

			worker.WorkPerformed += Worker_WorkPerformed;
			worker.WorkPerformed += Worker_WorkPerformed1;
			worker.DoWork(6, WorkType.Work);
		}

		private static void Worker_WorkPerformed1(int hours, WorkType workType)
		{
			Console.WriteLine($"Work DONE ");
		}

		private static void Worker_WorkPerformed(int hours, WorkType workType)
		{
		     Console.WriteLine($"Work of type {workType} : {hours} hours");  
		}


		/*
		private static int WorkPerform1(int hours, WorkType workType)
		{
			Console.WriteLine($"WorkPerformet1 : Work of type {workType} : {hours} hours");

			return hours + 1;
		}

		private static int WorkPerform2(int hours, WorkType workType)
		{
			Console.WriteLine($"WorkPerformet2 : Work of type {workType} : {hours} hours");

			return hours + 2;
		}

		private static int WorkPerform3(int hours, WorkType workType)
		{
			Console.WriteLine($"WorkPerformet3 : Work of type {workType} : {hours} hours");

			return hours + 3;
		}
		*/
	}
}
