using OsdbApi.Models.DbSettings;

namespace OsdbApi.Services.Soccer
{
	public class RostersService : SoccerServiceBase<Models.Soccer.Player>
	{
		public RostersService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.Players)
		{
		}
	}
}
