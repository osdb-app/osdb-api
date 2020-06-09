using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models.Soccer;
using OsdbApi.Services.Soccer;

namespace OsdbApi.Controllers.Soccer
{
	[Route("api/soccer/[controller]/[action]")]
	[ApiController]
	public class CountriesController : OsdbControllerBase<CountriesService>
	{
		public CountriesController(CountriesService service): base(service)
		{
		}

		public ActionResult<List<Country>> GetAll() => _service.Get();

		// GET api/soccer/countries/getById/<string>
		[HttpGet("{id:length(24)}")]
		public ActionResult<Country> GetById(string id)
		{
			var country = _service.Get(id);
			if (country == null)
			{
				return NotFound();
			}
			return country;
		}
	}
}
