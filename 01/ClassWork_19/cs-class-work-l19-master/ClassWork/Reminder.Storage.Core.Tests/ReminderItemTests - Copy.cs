using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;
using Reminder.Domain;

namespace Reminder.Storage.Core.Tests
{
	[TestClass]
	public class RemiderDomainTests
	{
		[TestMethod]
		public void Check_That_Remider_Sending_Succeded()
		{
			var remiderStorage = new RemiderDomainTests();
			ReminderDomain = new ReminderDomain(remiderStorage);

			bool delegateWasCalled = true;

			RemiderDomain.SendReminder += (s , e) =>
			{
				delegateWasCalled = true;
			}



			remiderDomain.Run();


		}

	}
}
