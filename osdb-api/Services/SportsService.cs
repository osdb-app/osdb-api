using OsdbApi.Models;
using OsdbApi.Models.DbSettings;

namespace OsdbApi.Services
{
	public class SportsService : ServiceBase<OsdbDbSettings, OsdbCollections, Sport>
	{
		public SportsService(OsdbDbSettings settings) : base(settings, settings.Collections.Sports)
		{
		}
	}
}
