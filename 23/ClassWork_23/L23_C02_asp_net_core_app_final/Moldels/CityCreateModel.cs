using System.ComponentModel.DataAnnotations;
using L23_C02_asp_net_core_app_final.DataStore;
using L23_C02_asp_net_core_app_final.Validation;

namespace L23_C02_asp_net_core_app_final.Moldels
{
	public class CityCreateModel
	{ 
		[Required(ErrorMessage = "The name of the city is a required field")]
		[MaxLength(100)]
		public string Name { get; set; }

		[MaxLength(255)]
		[DifferentValue(OtherProperty = "Name")]
		public string Description { get; set; }

		[Range(0, 100)]
		public int NumberOfPointsOfInterest { get; set; }

		public CityCreateModel()
		{
		}

		public CityCreateModel(CityData city)
		{
			Name = city.Name;
			Description = city.Description;
			NumberOfPointsOfInterest = city.NumberOfPointsOfInterest;
		}
	}
}
