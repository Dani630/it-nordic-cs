using System.Collections.Generic;

namespace L23_C01_asp_net_core_app.DataStore
{
	public class CitiesDataStore
	{
		private static CitiesDataStore _store;

		public List<CityData> Cities { get; private set; }

		private CitiesDataStore()
		{
			Cities = new List<CityData>
			{
				new CityData
				{
					Id = 1,
					Name = "Moscow",
					Description = "The capital of Russia"
				},
				new CityData
				{
					Id = 2,
					Name = "New York",
					Description = "The one of the biggest cities in the world"
				}
			};
		}

		public static CitiesDataStore GetInstance()
		{
			if (_store == null)
			{
				_store = new CitiesDataStore();
			}

			return _store;
		}
	}
}
