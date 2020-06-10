using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models.Soccer;
using OsdbApi.Services.Soccer;

namespace OsdbApi.Controllers.Soccer
{
	[Route("api/soccer/[controller]/[action]")]
	[ApiController]
	public class CountriesController : SoccerControllerBase<CountriesService, Country>
	{
		public CountriesController(CountriesService service): base(service)
		{
		}
	}
}
