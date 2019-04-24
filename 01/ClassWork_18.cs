using Microsoft.VisualStudio.TestTools.UnitTesting;
using Remider.Storage.Core;
using System;

namespace Remider.Storage.Core.Tests
{
	[TestClass]
	public class RemiderItemTest
	{
		
		[TestMethod]
		public void Constructor_Validly_Sets_Date_Poreperty()
		{
			// Preparing

			var expected = DateTimeOffset.Now;


			var reminderItem = new RemiderItem(
				Guid.Empty,
				expected,
				null,
				null);


			Assert.AreEqual(expected, reminderItem.Date);
		}

		//[TestMethod]
		public void Constructor_Validly_Sets_Id_Poreperty()
		{
			Guid expected = new Guid("C45A8CE6 - A68C - 4440 - 81FA - 910EA1668776");


			var reminderItem = new RemiderItem(
				expected,
				DateTimeOffset.MinValue,
				null,
				null);


			Assert.AreEqual(expected, reminderItem.Id);
		}

		//[TestMethod]
		public void TimeToSend_Is_Less_Than_Zero_For_Past_Date()
		{
			var time500ms = TimeSpan.FromMilliseconds(500);

			var reminderItem = new RemiderItem(
				Guid.Empty,
				DateTimeOffset.UtcNow + TimeSpan.FromMilliseconds(500),
				null,
				null);


			var actual = reminderItem.TimeToSend;

			Assert.IsTrue(actual < time500ms);
			Assert.IsTrue(actual > TimeSpan.Zero);
		}
	}
}

