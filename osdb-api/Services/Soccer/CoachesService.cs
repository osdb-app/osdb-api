using OsdbApi.Models.DbSettings;
using OsdbApi.Models.Soccer;

namespace OsdbApi.Services.Soccer
{
	public class CoachesService : SoccerServiceBase<Coach>
	{
		public CoachesService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.Coaches)
		{
		}
	}
}
