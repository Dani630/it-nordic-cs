using System.Linq;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using L23_C02_asp_net_core_app_final.DataStore;
using L23_C02_asp_net_core_app_final.Moldels;


namespace L23_C02_asp_net_core_app_final.Controllers
{
	[Route("/api/cities")]
	public class CitiesController : Controller
	{
		private ILogger<CitiesController> _logger;
		private ICitiesDataStore _citiesDataStore;

		public CitiesController(
			ILogger<CitiesController> logger,
			ICitiesDataStore citiesDataStore)
		{
			_logger = logger;
			_citiesDataStore = citiesDataStore;
		}

		[HttpGet]
		public IActionResult GetCities()
		{
			_logger.LogInformation(nameof(GetCities) + " called");

			return Ok(
				_citiesDataStore.Cities
					.Select(c => new CityGetModel(c)));
		}

		[HttpGet("{id}", Name = "GetCity")]
		public IActionResult GetCity(int id)
		{ 
			var city = _citiesDataStore
				.Cities
				.Where(x => x.Id == id)	
				.FirstOrDefault();

			if (city == null)
			{
				return NotFound();
			}

			return Ok(new CityGetModel(city));
		}

		[HttpPost()]
		public IActionResult CreateCity([FromBody] CityCreateModel city)
		{
			if (city == null)
			{
				return BadRequest();
			}

			//if (city.Description == city.Name)
			//{
			//	ModelState.AddModelError(
			//		"Description",
			//		"Description shouldn't be the same as Name.");
			//}

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			int newCityId = _citiesDataStore.Cities.Max(x => x.Id) + 1;

			var newCity = new CityData
			{
				Id = newCityId,
				Name = city.Name,
				Description = city.Description,
				NumberOfPointsOfInterest = city.NumberOfPointsOfInterest
			};

			_citiesDataStore.Cities.Add(newCity);

			return CreatedAtRoute("GetCity", new { id = newCityId }, newCity);
		}

		[HttpPut("{id}")]
		public IActionResult ReplaceCity(int id, [FromBody] CityReplaceModel cityModel)
		{
			if (cityModel == null)
			{
				BadRequest();
			}

			var city = _citiesDataStore.Cities
				.Where(x => x.Id == id)
				.FirstOrDefault();

			if (city == null)
			{
				NotFound();
			}

			city.Name = cityModel.Name;
			city.Description = cityModel.Description;
			city.NumberOfPointsOfInterest = cityModel.NumberOfPointsOfInterest;

			return NoContent();

		}

		[HttpPatch("{id}")]
		public IActionResult PatchCity(
			int id,
			[FromBody] JsonPatchDocument<CityModifyModel> patchDoc)
		{
			if (patchDoc == null)
			{
				BadRequest();
			}

			var city = _citiesDataStore.Cities
				.Where(x => x.Id == id)
				.FirstOrDefault();

			if (city == null)
			{
				NotFound();
			}

			var cityModelToPatch = new CityModifyModel(city);
			patchDoc.ApplyTo(cityModelToPatch);

			city.Name = cityModelToPatch.Name;
			city.Description = cityModelToPatch.Description;
			city.NumberOfPointsOfInterest = cityModelToPatch.NumberOfPointsOfInterest;

			return NoContent();
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteCity(int id)
		{
			var city = _citiesDataStore.Cities
				.Where(x => x.Id == id)
				.FirstOrDefault();

			if (city == null)
			{
				NotFound();
			}

			_citiesDataStore.Cities.Remove(city);

			return NoContent();
		}
	}
}