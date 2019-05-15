using L23_C01_asp_net_core_app.DataStore;

namespace L23_C01_asp_net_core_app.Moldels
{
	public class CityModifyModel
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public int NumberOfPointsOfInterest { get; set; }

		public CityModifyModel()
		{
		}

		public CityModifyModel(CityData city)
		{
			Name = city.Name;
			Description = city.Description;
			NumberOfPointsOfInterest = city.NumberOfPointsOfInterest;
		}
	}
}
