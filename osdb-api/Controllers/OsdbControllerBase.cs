using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using OsdbApi.Models.DbSettings;
using System.Collections.Generic;

namespace OsdbApi.Controllers
{
	public abstract class OsdbControllerBase<Service> : ControllerBase
	{
		protected readonly Service _service;

		public OsdbControllerBase(Service service)
		{
			_service = service;
		}
	}
}
