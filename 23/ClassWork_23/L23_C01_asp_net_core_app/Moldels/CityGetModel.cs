using L23_C01_asp_net_core_app.DataStore;

namespace L23_C01_asp_net_core_app.Moldels
{
	public class CityGetModel
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public int NumberOfPointsOfInterest { get; set; }

		public CityGetModel()
		{
		}

		public CityGetModel(CityData city)
		{
			Id = city.Id;
			Name = city.Name;
			Description = city.Description;
			NumberOfPointsOfInterest = city.NumberOfPointsOfInterest;
		}
	}
}
