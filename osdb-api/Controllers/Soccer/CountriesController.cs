using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models.Soccer;
using OsdbApi.Services.Soccer;

namespace OsdbApi.Controllers.Soccer
{
	[Route("api/soccer/[controller]/[action]")]
	[ApiController]
	public class CountriesController : ControllerBase
	{
		private readonly CountriesService _countriesService;
		public CountriesController(CountriesService countriesService)
		{
			_countriesService = countriesService;
		}

		public ActionResult<List<Country>> GetAll() => _countriesService.Get();

		// GET api/soccer/countries/getById/<string>
		[HttpGet("{id:length(24)}")]
		public ActionResult<Country> GetById(string id)
		{
			var country = _countriesService.Get(id);
			if (country == null)
			{
				return NotFound();
			}
			return country;
		}
	}
}
