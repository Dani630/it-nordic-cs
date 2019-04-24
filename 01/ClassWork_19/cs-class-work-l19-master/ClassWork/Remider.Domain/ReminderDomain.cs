using System;
using Reminder.Storage.Core;
using System.Threading;
using System.Linq;
using Reminder.Domain.Model;

namespace Remider.Domain
{
	public class ReminderDomain
	{
		const int _deltaToCheckAwatingRemiders = 1000;
		const int _deltaToSendReadyRemiders = 1000;

		private readonly IReminderStorage _storage;

		public Action<SendReminderModel> SendReminder { get; set; }

		public event EventHandler<SendingSuccededEventArgs> SedingSucceded;
		

		public ReminderDomain(IReminderStorage storage)
		{
			_storage = storage;
		}

		public void Run()
		{
			var awaitingRemiderCheckTimer = new Timer(
				CheckAvaitingRemider,
				null,
				TimeSpan.Zero,
				TimeSpan.FromMilliseconds(_deltaToCheckAwatingRemiders));


			var readyRemidersSendTimer = new Timer(
				SendReadyRemiders,
				null,
				TimeSpan.Zero,
				TimeSpan.FromMilliseconds(_deltaToSendReadyRemiders));
		}

		public void CheckAvaitingRemider(object dummy)
		{
			var ids  =_storage
				.Get(ReminderItemStatus.Awaiting)
				.Where(r => r.IsTimeToSend)
				.Select(r => r.Id)
				.ToList();

			_storage.UpdateStatus(ids , ReminderItemStatus.Ready);
		}

		public void Add (AddRemiderModel addRemiderModel)
		{
			_storage.Add(
				new ReminderItem
				{
					Date = addRemiderModel.Date,
					ContactId = addRemiderModel.ContactId,
					Message = addRemiderModel.Message,
					Status = ReminderItemStatus.Sent

				});
		}

		public void SendReadyRemiders (object dummy)
		{
				var ids = _storage
					.Get(ReminderItemStatus.Ready)
					.Where(r => r.IsTimeToSend)
					.Select(r =>
					new SendReminderModel
					{
						Iid = r.Id,
						Message = r.Message,
						ContactId = r.ContactId
					})
					.ToList();
				foreach (SendReminderModel sendRemider in SendReadyRemidersModel)
				{
				try
				{
					SendReminder?.Invoke(sendRemider);

					_storage.UpdateStatus
						(
						sendRemider.Iid,
						ReminderItemStatus.Sent);

				}
				catch (Exception excpetion)
				{
					_storage.UpdateStatus(
						sendRemider.Iid,
						ReminderItemStatus.Failed);

					
				}
				}
		}
	}
}
