using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_14
{
	class ErrorsList : IDisposable , IEnumerable<string>
	{
		public  string Category { get; private set; }

		private List<string> _errors { get; set; }

		public static string OutputPrefixFormat { get; set; }

		
		ErrorsList()
		{
			OutputPrefixFormat = Convert.ToString(DateTimeOffset.Now);
		//	OutputPrefixFormat = /*Convert.ToString(*/new DateTimeOffset(04 / 7 / 2019);
		}

		public ErrorsList (string catrgory)
		{
			Category = catrgory;
			_errors = new List<string>();
		}

		public void WriteToConsole()
		{
			foreach (var _er in _errors)
			{
				Console.WriteLine($"{_er} : {DateTime.Now.ToString(OutputPrefixFormat)}\n");
			}
		}

		public void Dispose()
		{
			if (_errors != null)
			{
				_errors.Clear();
				_errors = null;
			}
		}

		public void Add (string errorMessage)
		{
			_errors.Add(errorMessage);
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _errors.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _errors.GetEnumerator();
		}
	}
}
