using OsdbApi.Models.DbSettings;

namespace OsdbApi.Services.Soccer
{
	public class SeasonsService : SoccerServiceBase<Models.Soccer.Player>
	{
		public SeasonsService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.Players)
		{
		}
	}
}
