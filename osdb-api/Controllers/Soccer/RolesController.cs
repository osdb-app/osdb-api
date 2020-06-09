using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models.Soccer;
using OsdbApi.Services.Soccer;

namespace OsdbApi.Controllers.Soccer
{
	[Route("api/soccer/[controller]/[action]")]
	[ApiController]
	public class RolesController : OsdbControllerBase<RolesService>
	{
		public RolesController(RolesService service) : base(service)
		{
		}

		public ActionResult<List<Role>> GetAll() => _service.Get();

		// GET api/soccer/countries/getById/<string>
		[HttpGet("{id:length(24)}")]
		public ActionResult<Role> GetById(string id)
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
