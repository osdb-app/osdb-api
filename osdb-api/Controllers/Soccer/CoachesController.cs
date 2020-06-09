using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models.Soccer;
using OsdbApi.Services.Soccer;

namespace OsdbApi.Controllers.Soccer
{
	[Route("api/soccer/[controller]/[action]")]
	[ApiController]
	public class CoachesController : OsdbControllerBase<CoachesService>
	{
		public CoachesController(CoachesService service) : base(service)
		{
		}

		public ActionResult<List<Coach>> GetAll() => _service.Get();

		// GET api/soccer/countries/getById/<string>
		[HttpGet("{id:length(24)}")]
		public ActionResult<Coach> GetById(string id)
		{
			var result = _service.Get(id);
			if (result == null)
			{
				return NotFound();
			}
			return result;
		}
	}
}
