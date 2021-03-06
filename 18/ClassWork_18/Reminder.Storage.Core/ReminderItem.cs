﻿using System;

namespace Reminder.Storage.Core
{
	public class ReminderItem
	{
		public Guid Id { get; internal set; }

		public DateTimeOffset Date { get; set; }

		public string Message { get; set; }
		
		public string ContactId { get; set; }

		public TimeSpan TimeToSend => Date - DateTimeOffset.UtcNow;

		public ReminderItem(
			Guid id,
			DateTimeOffset date,
			string message,
			string contactId)
		{
			Id = id;
			Date = date;
			Message = message;
			ContactId = contactId;
		}
	}
}
