using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_12
{
	class BaseDocument
	{
		public string DocName { get; set; }
		public string DocNumber { get; set; }
		public DateTimeOffset IssueDate { get; set; }
		virtual public string PropertiesString
		{
			get
			{
				return
					$"DocName : {DocName}\nDocNumber : {DocNumber}\nIssueDate : {IssueDate}\n";
			}
		}

		public BaseDocument (string DocName , string DocNumber , DateTimeOffset IssueDate)
		{
			this.DocName = DocName;
			this.DocNumber = DocNumber;
			this.IssueDate = IssueDate;
		}
		public void WriteToConsole()
		{
			Console.WriteLine(PropertiesString);
		}
	}
}
