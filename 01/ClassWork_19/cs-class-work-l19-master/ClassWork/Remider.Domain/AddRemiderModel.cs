using System;

namespace Remider.Domain
{
	public class AddRemiderModel
	{
		public string ContactId { get; set; }

		public DateTimeOffset Date { get; set; }

		public string Message { get; set; }
	}
}