using OsdbApi.Models.DbSettings;
using OsdbApi.Models.Soccer;


namespace OsdbApi.Services.Soccer
{
	public class LeaguesService : SoccerServiceBase<League>
	{
		public LeaguesService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.Leagues)
		{
		}
	}
}
