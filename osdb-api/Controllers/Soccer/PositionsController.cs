using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models.Soccer;
using OsdbApi.Services.Soccer;

namespace OsdbApi.Controllers.Soccer
{
	[Route("api/soccer/[controller]/[action]")]
	[ApiController]
	public class PositionsController : SoccerControllerBase<PositionsService, Position>
	{
		public PositionsController(PositionsService service) : base(service)
		{
		}
	}
}
