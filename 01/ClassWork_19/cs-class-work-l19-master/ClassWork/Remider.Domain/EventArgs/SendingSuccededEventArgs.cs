using System;
using System.Collections.Generic;
using System.Text;
using Remider.Domain;
using Reminder.Domain.Model;


namespace Reminder.Domain.EventArgs
{
	public class SendingSuccededEventArgs : System.EventArgs
	{
		public SendReminderModel Remider { get; set;  }

		public SendingSuccededEventArgs(SendReminderModel remider)
		{
			Remider = remider;
		}
	}
}
