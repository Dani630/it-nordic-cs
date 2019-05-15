using System.Collections.Generic;

namespace L23_C02_asp_net_core_app_final.DataStore
{
	public class CitiesDataStore: ICitiesDataStore
	{
		public List<CityData> Cities { get; private set; }

		public CitiesDataStore()
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
	}
}
