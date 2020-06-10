using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models;
using OsdbApi.Models.DbSettings;
using OsdbApi.Services;

namespace OsdbApi.Controllers.Soccer
{
	public class SoccerControllerBase<Service, Model> : OsdbControllerBase<Service> where Service: SoccerServiceBase<Model> where Model: CollectionEntry
	{
		public SoccerControllerBase(Service service) : base(service)
		{
		}

		public ActionResult<List<Model>> GetAll() => _service.Get();

		// GET api/soccer/countries/getById/<string>
		[HttpGet("{id:length(24)}")]
		public ActionResult<Model> GetById(string id)
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
