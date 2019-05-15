using System.Linq;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using L23_C01_asp_net_core_app.DataStore;
using L23_C01_asp_net_core_app.Moldels;

namespace L23_C01_asp_net_core_app.Controllers
{
	[Route("/api/cities")]
	public class CitiesController : Controller
	{
		[HttpGet]
		public IActionResult GetCities()
		{
			var citiesDataStore = CitiesDataStore.GetInstance();
			return Ok(
				citiesDataStore.Cities
					.Select(c => new CityGetModel(c)));
		}

		[HttpGet("{id}", Name = "GetCity")]
		public IActionResult GetCity(int id)
		{ 
			var citiesDataStore = CitiesDataStore.GetInstance();
			var city = citiesDataStore
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

			var citiesDataStore = CitiesDataStore.GetInstance();
			int newCityId = citiesDataStore.Cities.Max(x => x.Id) + 1;

			var newCity = new CityData
			{
				Id = newCityId,
				Name = city.Name,
				Description = city.Description,
				NumberOfPointsOfInterest = city.NumberOfPointsOfInterest
			};

			citiesDataStore.Cities.Add(newCity);

			return CreatedAtRoute("GetCity", new { id = newCityId }, newCity);
		}

		[HttpPut("{id}")]
		public IActionResult ReplaceCity(int id, [FromBody] CityReplaceModel cityModel)
		{
			if (cityModel == null)
			{
				BadRequest();
			}

			var citiesDataStore = CitiesDataStore.GetInstance();

			var city = citiesDataStore.Cities
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

			var citiesDataStore = CitiesDataStore.GetInstance();

			var city = citiesDataStore.Cities
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
			var citiesDataStore = CitiesDataStore.GetInstance();
			var city = citiesDataStore.Cities
				.Where(x => x.Id == id)
				.FirstOrDefault();

			if (city == null)
			{
				NotFound();
			}

			citiesDataStore.Cities.Remove(city);

			return NoContent();
		}
	}
}