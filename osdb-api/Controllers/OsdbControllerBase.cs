using Microsoft.AspNetCore.Mvc;

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
