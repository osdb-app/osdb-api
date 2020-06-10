using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models.Soccer;
using OsdbApi.Services.Soccer;

namespace OsdbApi.Controllers.Soccer
{
	[Route("api/soccer/[controller]/[action]")]
	[ApiController]
	public class SeasonsController : SoccerControllerBase<SeasonsService, Season>
	{
		public SeasonsController(SeasonsService service) : base(service)
		{
		}
	}
}
