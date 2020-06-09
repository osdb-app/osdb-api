using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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
