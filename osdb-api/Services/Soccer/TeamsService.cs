using OsdbApi.Models.DbSettings;

namespace OsdbApi.Services.Soccer
{
	public class TeamsService : SoccerServiceBase<Models.Soccer.Team>
	{
		public TeamsService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.Teams)
		{
		}
	}
}
