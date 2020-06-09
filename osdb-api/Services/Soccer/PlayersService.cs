using OsdbApi.Models.DbSettings;

namespace OsdbApi.Services.Soccer
{
	public class PlayersService : SoccerServiceBase<Models.Soccer.Player>
	{
		public PlayersService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.Players)
		{
		}
	}
}
