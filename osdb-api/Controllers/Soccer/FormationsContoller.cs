using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models.Soccer;
using OsdbApi.Services.Soccer;

namespace OsdbApi.Controllers.Soccer
{
	[Route("api/soccer/[controller]/[action]")]
	[ApiController]
	public class FormationsController : SoccerControllerBase<FormationsService, Formation>
	{
		public FormationsController(FormationsService service) : base(service)
		{
		}
	}
}
