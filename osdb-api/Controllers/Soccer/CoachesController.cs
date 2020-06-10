using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models.Soccer;
using OsdbApi.Services.Soccer;

namespace OsdbApi.Controllers.Soccer
{
	[Route("api/soccer/[controller]/[action]")]
	[ApiController]
	public class CoachesController : SoccerControllerBase<CoachesService, Coach>
	{
		public CoachesController(CoachesService service) : base(service)
		{
		}
	}
}
