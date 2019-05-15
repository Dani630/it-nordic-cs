using L23_C02_asp_net_core_app_final.DataStore;

namespace L23_C02_asp_net_core_app_final.Moldels
{
	public class CityReplaceModel
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public int NumberOfPointsOfInterest { get; set; }

		public CityReplaceModel()
		{
		}

		public CityReplaceModel(CityData city)
		{
			Name = city.Name;
			Description = city.Description;
			NumberOfPointsOfInterest = city.NumberOfPointsOfInterest;
		}
	}
}
