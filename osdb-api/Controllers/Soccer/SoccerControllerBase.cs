using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OsdbApi.Models;
using OsdbApi.Services;

namespace OsdbApi.Controllers.Soccer
{
	public class SoccerControllerBase<Service, Model> : OsdbControllerBase<Service> where Service: SoccerServiceBase<Model> where Model: CollectionEntry
	{
		public SoccerControllerBase(Service service) : base(service)
		{
		}

		public ActionResult<List<Model>> GetAll() => _service.Get();

		// GET api/soccer/[controller]/getById/<string>
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

		// POST api/soccer/[controller]/add/
		[HttpPost]
		public ActionResult<Model> Add(Model entry)
		{
			_service.Create(entry);
			// This is the right way if doing it but somehow I get the below error
			// System.InvalidOperationException: No route matches the supplied values.
			//return CreatedAtRoute("GetById", new { id = entry.Id.ToString() }, entry);
			var added = _service.Get(entry.Id);
			if (added == null)
			{
				return NotFound();
			}
			return added;
		}

		// PUT api/soccer/[controller]/update/<string>
		[HttpPut("{id:length(24)}")]
		public IActionResult Update(string id, Model replacement)
		{
			var entry = _service.Get(id);
			if (entry == null)
			{
				return NotFound();
			}
			_service.Update(id, replacement);
			return NoContent();
		}

		// DELETE api/soccer/[controller]/remove/<string>
		[HttpDelete("{id:length(24)}")]
		public IActionResult Remove(string id)
		{
			var book = _service.Get(id);
			if (book == null)
			{
				return NotFound();
			}
			_service.Remove(book.Id);
			return NoContent();
		}
	}
}
