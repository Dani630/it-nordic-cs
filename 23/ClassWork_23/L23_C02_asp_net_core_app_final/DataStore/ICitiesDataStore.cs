using System.Collections.Generic;

namespace L23_C02_asp_net_core_app_final.DataStore
{
	public interface ICitiesDataStore
	{
		List<CityData> Cities { get; }
	}
}
