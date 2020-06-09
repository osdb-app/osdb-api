using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models.Soccer;
using OsdbApi.Services.Soccer;
using System.Collections.Generic;

namespace OsdbApi.Controllers.Soccer
{
	[Route("api/soccer/[controller]/[action]")]
	[ApiController]
	public class LeaguesController : OsdbControllerBase<LeaguesService>
	{
		public LeaguesController(LeaguesService service) : base(service)
		{
		}

		public ActionResult<List<League>> GetAll() => _service.Get();

		// GET api/soccer/countries/getById/<string>
		[HttpGet("{id:length(24)}")]
		public ActionResult<League> GetById(string id)
		{
			var league = _service.Get(id);
			if (league == null)
			{
				return NotFound();
			}
			return league;
		}
	}
}
