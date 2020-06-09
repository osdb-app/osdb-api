using OsdbApi.Models.DbSettings;

namespace OsdbApi.Services.Soccer
{
	public class SeasonsService : SoccerServiceBase<Models.Soccer.Season>
	{
		public SeasonsService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.Seasons)
		{
		}
	}
}
