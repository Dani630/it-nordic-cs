﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reminder.Storage.SqlServer.ADO.Tests
{
	[TestClass]
	public class SqlReminderStorageTests
	{
		private const string _connectionString =
			@"Data Source=localhost\SQLEXPRESS;Initial Catalog=ReminderTests;Integrated Security=True;";

		[TestInitialize]
		public void TestInitialize()
		{
			new SqlReminderStorageInit(_connectionString).InitializeDatabase();
		}

		[TestMethod]
		public void Method_Add_Returns_Not_Empty_Guid()
		{
			var storage = new SqlReminderStorage(_connectionString);

			Guid actual = storage.Add(new Core.ReminderItemRestricted
			{
				ContactId = "TestContactId",
				Date = DateTimeOffset.Now.AddHours(1),
				Message = "Test Message",
				Status = Core.ReminderItemStatus.Awaiting
			});

			Assert.AreNotEqual(Guid.Empty, actual);
		}
	}
}
