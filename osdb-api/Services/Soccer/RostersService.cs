using OsdbApi.Models.DbSettings;

namespace OsdbApi.Services.Soccer
{
	public class RostersService : SoccerServiceBase<Models.Soccer.Roster>
	{
		public RostersService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.Rosters)
		{
		}
	}
}
