using OsdbApi.Models.DbSettings;

namespace OsdbApi.Services.Soccer
{
	public class RolesService : SoccerServiceBase<Models.Soccer.Player>
	{
		public RolesService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.Players)
		{
		}
	}
}
