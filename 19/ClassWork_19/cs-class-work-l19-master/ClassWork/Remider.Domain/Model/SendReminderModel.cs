using System;

namespace Reminder.Domain.Model
{
	/// <summary>
	/// The single reminder item.
	/// </summary>
	public class SendReminderModel
	{
		/// <summary>
		/// Gets the identifier.
		/// </summary>
	   public Guid Iid { get; } = Guid.NewGuid();

		/// <summary>
		/// The message of the reminder item for sending to the recepient.
		/// </summary>
		public string Message { get; set; }


		public string ContactId { get; set; }
	}
}

