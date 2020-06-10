using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models.Soccer;
using OsdbApi.Services.Soccer;
using System.Collections.Generic;

namespace OsdbApi.Controllers.Soccer
{
	[Route("api/soccer/[controller]/[action]")]
	[ApiController]
	public class LeaguesController : SoccerControllerBase<LeaguesService, League>
	{
		public LeaguesController(LeaguesService service) : base(service)
		{
		}
	}
}
