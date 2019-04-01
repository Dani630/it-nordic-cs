using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_12
{
	class Passport : BaseDocument
	{
		public string Country { get; set; }
		public string PersonName { get; set; }
		override public string PropertiesString
		{
			get
			{
				return
			 		$"DocName : {DocName}\nDocNumber : {DocNumber}\nIssueDate : {IssueDate}\nCountry : {Country}\nPersonName : {PersonName}";
			}
		}

		public Passport(string DocNumber, DateTimeOffset IssueDate, string Country, string PersonName) : base ("Passport" , DocNumber , IssueDate)
		{
			this.Country = Country;
			this.PersonName = PersonName;
		}
		/*
		public void ChangelssueDate(DateTimeOffset)
		{
			
		}
		/*
		public void WriteToConsole()
		{
			Console.WriteLine(PropertiesString);
		}
		*/
	}
}
