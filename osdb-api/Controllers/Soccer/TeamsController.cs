using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models.Soccer;
using OsdbApi.Services.Soccer;

namespace OsdbApi.Controllers.Soccer
{
	[Route("api/soccer/[controller]/[action]")]
	[ApiController]
	public class TeamsController : SoccerControllerBase<TeamsService, Team>
	{
		public TeamsController(TeamsService service) : base(service)
		{
		}
	}
}
