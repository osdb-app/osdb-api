using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OsdbApi.Services;

namespace OsdbApi.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class SportsController : OsdbControllerBase<SportsService>
	{
		private readonly SportsService _sportsService;
		public SportsController(SportsService sportsService) : base(sportsService)
		{
			_sportsService = sportsService;
		}

		public ActionResult<List<Models.Sport>> GetAll() => _sportsService.Get();

		// GET api/sports/getById/<string>
		[HttpGet("{id:length(24)}")]
		public ActionResult<Models.Sport> GetById(string id)
		{
			var sport = _sportsService.Get(id);
			if (sport == null)
			{
				return NotFound();
			}
			return sport;
		}
	}
}
