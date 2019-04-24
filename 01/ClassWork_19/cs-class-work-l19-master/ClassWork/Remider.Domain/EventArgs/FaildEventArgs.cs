using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Domain.EventAargs
{
	public class SendingFaildEventArgs : EventArgs
	{
		public SendReminderModel Remider { get; set; }

		public Exception Exception { get; set; }

		public SendingFaildEventArgs(SendRemiderModel remider)
		{
			Remider = remider;
		}
	}
}
