using OsdbApi.Models.DbSettings;

namespace OsdbApi.Services.Soccer
{
	public class PositionsService : SoccerServiceBase<Models.Soccer.Position>
	{
		public PositionsService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.Positions)
		{
		}
	}
}
